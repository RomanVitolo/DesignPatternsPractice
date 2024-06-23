using UnityEngine;     

namespace Core.Runtime.PrototypeExample.Samples
{
    public class DataSpawner : MonoBehaviour
    {
        void Start()
        {
            // 1
            FactoryPrototype<IPrototype> factory = new FactoryPrototype<IPrototype>
            {
                // 2
                ["Ogre"] = new Enemy(10, "RAWR", "Ogre", new Item("Poison dart")),
                ["Knight"] = new Enemy(15, "To Arms!", "Ash Knight", new Item("Shuriken"))
            };
            // 3
            IPrototype ogrePrototype = (Enemy)factory["Ogre"].DeepClone();
            IPrototype knightPrototye = (Enemy)factory["Knight"].DeepClone();
    
            // 4
            if(ogrePrototype is Enemy ogreEnemy)
            {
                ogreEnemy.Print();
            }
            if(knightPrototye is Enemy knightEnemy)
            {
                knightEnemy.Print();
            } 
        }
    }
}
