using UnityEngine;

namespace Core.Runtime.FactoryExample.Samples
{
    public class CursedKnifeFactory : AbstractCreator    
    {
        public CursedKnifeFactory(GameObject prefabModel) : base(prefabModel)
        {
            Spawner.name = "Cursed Knife Factory";
        }
        
        public override IItem Create()    
        {
            var knife = GameObject.Instantiate(Model);
            knife.AddComponent<CursedKnife>();
            knife.transform.position = new Vector3(-0.6f, 0.3f, -7.6f);
            knife.transform.SetParent(Spawner.transform);
        
            return knife.GetComponent<CursedKnife>(); 
        }  
    }
}