using UnityEngine;

namespace Core.Runtime.FactoryExample.Samples
{
    public abstract class AbstractCreator
    {
        public GameObject Spawner { get; protected set; }
        public GameObject Model { get; protected set; }

        public AbstractCreator(GameObject model)
        {
            Spawner = new GameObject();
            Model = model;
        }
        
        public abstract IItem Create();
    }   
}