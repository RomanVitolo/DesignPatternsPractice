using UnityEngine;

namespace Core.Runtime.FactoryExample.Samples
{
    public class PebbleFactory : AbstractCreator    
    {
        public PebbleFactory(GameObject prefabModel) : base(prefabModel)
        {
            Spawner.name = "Pebble Factory";
        }
        
        // 2
        public override IItem Create()
        {
            var pebble = GameObject.Instantiate(Model);
            pebble.AddComponent<Pebble>();
            pebble.transform.position = new Vector3(-2.2f, 0.3f, -7f);
            pebble.transform.SetParent(Spawner.transform);

            return pebble.GetComponent<Pebble>();
        }        
    }
}