using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

namespace Core.Runtime.FactoryExample.Samples
{
    public class ReflectionFactory
    {
        public GameObject Spawner { get; protected set; }
        public Dictionary<string, Type> Items { get; } = new Dictionary<string, Type>();

        public ReflectionFactory()
        {
            Spawner = new GameObject();
            Spawner.name = "Reflection Factory";  
            
            var itemTypes = Assembly.GetAssembly(typeof(IItem)).GetTypes();

            var filteredItems = itemTypes.Where(item => 
                !item.IsInterface && typeof(IItem).IsAssignableFrom(item));

            foreach (var type in filteredItems)
            {
                Items.Add(type.Name, type);  
            }
        }

        public IItem Create(string itemName, GameObject prefabModel, Vector3 position)
        {
            if (Items.ContainsKey(itemName))    
            {
                Type type = Items[itemName];
                // 4
                var obj = GameObject.Instantiate(prefabModel);
                var item = obj.AddComponent(type) as IItem;    
                // 5
                obj.transform.position = position;
                obj.transform.SetParent(Spawner.transform);    
                return obj.GetComponent(type) as IItem;
            }
            return null;                
        }
    }
}