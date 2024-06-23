using UnityEngine;

namespace Core.Runtime.PrototypeExample.Samples
{
    public class ComponentSpawner : MonoBehaviour
    {
        // 1
        public Clone OgrePrefab;    
        public Clone AshKnightPrefab;    
        private readonly FactoryPrototype<Clone> _enemyFactory = new FactoryPrototype<Clone>();    
        // 2
        private void Awake()    
        {
            _enemyFactory["Ogre"] = OgrePrefab;    
            _enemyFactory["Knight"] = AshKnightPrefab;    
        }

        private void Start()
        {
            // 3
            for (int i = 0; i < 10; i++)    
            {
                // 4
                BaseEnemy clonedEnemy = null;    
                var random = Random.Range(1, 3);    
          
                // 5
                switch (random)    
                {
                    case 1:    
                        clonedEnemy = _enemyFactory["Ogre"].Copy<Ogre>();    
                        break;    
                    case 2:    
                        clonedEnemy = _enemyFactory["Knight"].Copy<AshKnight>();   
                        break;    
                }
                // 6
                if(clonedEnemy)
                {
                    clonedEnemy.Attack();
                }
            }
        }
    }
}