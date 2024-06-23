using System.Collections.Generic;

namespace Core.Runtime.PrototypeExample.Samples
{
    public class FactoryPrototype<T>
    {
        // 2
        private Dictionary<string, T> objects = new Dictionary<string, T>();    
        // 3
        public T this[string key]
        {
            // 4
            get
            {
                if (objects.ContainsKey(key))  
                    return objects[key];  
                
                throw new KeyNotFoundException("Key not found: " + key);
            }
        
            // 5
            set
            {
                if (objects.ContainsKey(key))
                {
                    objects[key] = value;
                }
                else
                {
                    objects.Add(key, value);
                }
            }
        }
    }
}