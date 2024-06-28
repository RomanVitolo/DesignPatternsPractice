using UnityEngine;

namespace Core.Runtime.FactoryExample.Samples
{
    public class PotionFactory : AbstractCreator    
    {
        public PotionFactory(GameObject prefabModel) : base(prefabModel)
        {
            Spawner.name = "Potion Factory";
        }
        
        public override IItem Create()
        {
            var potion = GameObject.Instantiate(Model);
            potion.AddComponent<Potion>();
            potion.transform.position = new Vector3(0.6f, 0.3f, -7f);
            potion.transform.SetParent(Spawner.transform);

            return potion.GetComponent<Potion>();
        }     
    }
}