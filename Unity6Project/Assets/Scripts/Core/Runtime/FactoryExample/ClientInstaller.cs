using System.Collections.Generic;
using UnityEngine;

namespace Core.Runtime.FactoryExample.Samples
{
    public class ClientInstaller : MonoBehaviour
    {
        public ItemButton ButtonPrefab;
            
        public GameObject PebbleModel;
        public GameObject KnifeModel;
        public GameObject PotionModel;
        
        private void Start()
        {      
            #region AbstractCreator

            /*List<AbstractCreator> factories = new List<AbstractCreator>()
            {
                new PebbleFactory(PebbleModel),
                new CursedKnifeFactory(KnifeModel),
                new PotionFactory(PotionModel)
            };         
            
            foreach (AbstractCreator factory in factories)
            {
                var button = Instantiate(ButtonPrefab);
                IItem item = factory.Create();
                button.Configure(item);
                button.transform.SetParent(this.transform);
            }*/
            #endregion
            
            #region ConcreteCreatorFactory 
                                             
            /*var itemFactory = new ParameterizedCreator();

            var items = new List<IItem>()
            {
                itemFactory.Create("Normal"),
                itemFactory.Create("Rare"),
                itemFactory.Create("Rare")
            };
            
            foreach (var item in items)
            {
                var button = Instantiate(ButtonPrefab);
                button.Configure(item);
                button.transform.SetParent(this.transform);
            }*/    
            
            #endregion        

            #region ConcreteFactoryPro  
            /*var creator = new ConcreteCreator();

            foreach (var item in creator.Items)
            {
                var button = Instantiate(ButtonPrefab);
                button.Configure(item);
                button.transform.SetParent(this.transform);
            }*/            
            #endregion     

            #region ReflectionFactoryPro
            List<Vector3> pos = new List<Vector3>()
            {
                new Vector3(-2.2f, 0.3f, -7f),
                new Vector3(-0.6f, 0.3f, -7.6f),
                new Vector3(0.6f, 0.3f, -7f)
            };
            var itemFactory = new ReflectionFactory();
            var items = new List<IItem>()
            {
                // 3
                itemFactory.Create("Pebble", PebbleModel, pos[0]),    
                itemFactory.Create("CursedKnife", KnifeModel, pos[1]), 
                itemFactory.Create("Potion", PotionModel, pos[2])    
            };
            foreach (IItem item in items)
            {
                var button = Instantiate(ButtonPrefab);
                button.Configure(item);
                button.transform.SetParent(this.transform);
            }                             
            #endregion"         
        }
    }
}