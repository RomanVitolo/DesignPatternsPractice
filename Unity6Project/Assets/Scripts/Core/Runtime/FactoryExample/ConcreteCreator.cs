﻿using System.Collections.Generic;
using UnityEngine;

namespace Core.Runtime.FactoryExample.Samples
{
    public class ConcreteCreator
    {
        // 1
        public GameObject Spawner { get; protected set; }
        // 2
        public GameObject PebbleModel { get; protected set; }
        public GameObject KnifeModel { get; protected set; }
        public GameObject PotionModel { get; protected set; }
        // 3
        protected List<IItem> _items = new List<IItem>();
        public List<IItem> Items
        {
            get { return _items; }
        }
        // 4
        public ConcreteCreator()
        {
            Spawner = new GameObject();
            Spawner.name = "Concrete Factory";
            // 5
            PebbleModel = Resources.Load("FactorySample/Pebble") as GameObject;
            KnifeModel = Resources.Load("FactorySample/Knife") as GameObject;
            PotionModel = Resources.Load("FactorySample/Potion") as GameObject;
            // 6
            CreateInventory();
        }
        
        public virtual IItem NormalItem()
        {
            // 1
            var pebble = GameObject.Instantiate(PebbleModel);
            var item = pebble.AddComponent<Pebble>();
            pebble.transform.position = new Vector3(-2.2f, 0.3f, -7f);
            pebble.transform.SetParent(Spawner.transform);
            _items.Add(item);
            return pebble.GetComponent<Pebble>();
        }
        public virtual IItem RareItem()
        {
            // 2
            var knife = GameObject.Instantiate(KnifeModel);
            var item = knife.AddComponent<CursedKnife>();
            knife.transform.position = new Vector3(-0.6f, 0.3f, -7.6f);
            knife.transform.SetParent(Spawner.transform);
            _items.Add(item);
            return knife.GetComponent<CursedKnife>();
        }
        public virtual IItem HealingItem()
        {
            // 3
            var potion = GameObject.Instantiate(PotionModel);
            var item = potion.AddComponent<Potion>();
            potion.transform.position = new Vector3(0.6f, 0.3f, -7f);
            potion.transform.SetParent(Spawner.transform);
            _items.Add(item);
            return potion.GetComponent<Potion>();
        }
        
        public List<IItem> CreateInventory()
        {
            return new List<IItem>()
            {
                NormalItem(),
                RareItem(),
                HealingItem()
            };
        }
    }
}