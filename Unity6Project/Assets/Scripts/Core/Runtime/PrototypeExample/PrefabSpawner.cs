using UnityEngine;

namespace Core.Runtime.PrototypeExample.Samples
{
    public class PrefabSpawner : MonoBehaviour
    {
        // 1
        public BaseEnemy OgrePrefab;    
        public BaseEnemy AshKnightPrefab;    
        private FactoryPrototype<ICopy> _enemyFactory = new FactoryPrototype<ICopy>();
        // 2
        void Awake()    
        {
            _enemyFactory["Ogre"] = OgrePrefab;    
            _enemyFactory["Knight"] = AshKnightPrefab;    
        }
        void Start()
        {
            // 3
            for (int i = 0; i < 10; i++)    
            {
                // 4
                BaseEnemy clone = null;    
                var random = Random.Range(1, 3);    
            
                // 5
                switch (random)    
                {
                    case 1:    
                        clone = (BaseEnemy)_enemyFactory["Ogre"].Copy(OgrePrefab.transform); 
                        break;    
                    case 2:    
                        clone = (BaseEnemy)_enemyFactory["Knight"].Copy(AshKnightPrefab.transform);   
                        break;    
                }
                // 6
                if(clone)
                {
                    clone.Attack();
                }
            }
        }
    }
}