using UnityEngine;

namespace Core.Runtime.Singleton.Samples
{
    public class ScriptableSingleton<T> : ScriptableObject where T: ScriptableObject
    {
        // 2
        private static T _instance;    
        public static T Instance   
        {
            get    
            {
                // 3
                if (_instance == null)    
                {
                    T[] singletons = Resources.LoadAll<T>("SingletonSample");   
                    // 4
                    if(singletons == null || singletons.Length < 1)    
                    {
                        throw new System.Exception("No " + typeof(T).Name + " singleton objects found...");    
                    }
                    // 5
                    if(singletons.Length > 1)    
                    {
                        Debug.LogWarning("More than one " + typeof(T).Name + " singleton object found...");    
                    }
                    // 6
                    _instance = singletons[0];   
                    Debug.Log(typeof(T).Name + " singleton instance fetched!");
                }
                return _instance;   
            }
        }
    }
}