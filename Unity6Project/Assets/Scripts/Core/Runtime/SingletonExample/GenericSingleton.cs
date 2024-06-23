using UnityEngine;

namespace Core.Runtime.Singleton.Samples
{
    public class GenericSingleton<T> : MonoBehaviour where T: MonoBehaviour
    {
        private static readonly object _threadLock = new object();    
        // 2
        private static bool _isQuitting = false;   
        private static T _instance;    
        public static T Instance    
        {
            get    
            {
                // 3
                if (_isQuitting)   
                    return null;

                if (_instance != null) return _instance;
                _instance = FindAnyObjectByType<T>();    
                // 4
                lock (_threadLock)
                {
                    if (_instance != null) return _instance;
                    var singletonGO = new GameObject
                    {
                        name = typeof(T).Name + " (Persists)"
                    };
                    _instance = singletonGO.AddComponent<T>();
                    DontDestroyOnLoad(singletonGO);
                    Debug.Log("New instance created!");
                }
                return _instance;    
            }
        }
        // 5
        public void OnDestroy()   
        {
            _isQuitting = true;    
        }
    }
}