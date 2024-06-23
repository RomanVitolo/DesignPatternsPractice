using UnityEngine;

namespace Core.Runtime.PrototypeExample.Samples
{
    public class Clone : MonoBehaviour
    {
        public T Copy<T>() where T : Component    
        {
            // 3
            Clone instance = Instantiate(this);    
            // 4
            GameObject spawner = GameObject.Find("Enemy Spawner");   
            var enemyRange = new Vector3(Random.Range(-7, 7), 0, Random.Range(-7, 7));    
            // 5
            instance.transform.SetParent(spawner.transform);    
            instance.transform.localPosition = enemyRange;    
            // 6
            return instance.GetComponent<T>();    
        }
    }
}