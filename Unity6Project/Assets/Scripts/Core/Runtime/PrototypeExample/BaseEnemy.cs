using UnityEngine;

namespace Core.Runtime.PrototypeExample.Samples
{
    public abstract class BaseEnemy : MonoBehaviour, ICopy
    {
        [SerializeField] protected int Damage;
        [SerializeField] protected string Message;
        [SerializeField] protected string Name;
        public void OnEnable()
        {
            Debug.LogFormat($"{Message} - an {Name} entered the arena.");
        }
        public virtual void Attack()
        {
            Debug.LogFormat($"{Name} attacks for {Damage} HP!");
        }
        // 3
        public ICopy Copy(Transform parent)    
        {
            // 4
            BaseEnemy clone = Instantiate(this);    
            // 5
            var clonePosition = new Vector3(Random.Range(-7, 7), 0, Random.Range(-7, 7));    
            // 6
            clone.transform.SetParent(parent);    
            clone.transform.localPosition = clonePosition;   
            // 7
            return clone;    
        }
    }
}        