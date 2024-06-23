using UnityEngine;
// 1
using UnityEngine.SceneManagement; 

namespace Core.Runtime.Singleton.Samples
{
    [CreateAssetMenu(fileName = "Game Manager", menuName = "ScriptableObjects/Game Manager")]
    public class SOManager : ScriptableSingleton<SOManager>
    {
        // 4
        public int score = 0;    
        public int startingLevel = 1;    
        public void StartGame()   
        {
            Debug.Log("New game has started with SO manager...");
            SceneManager.LoadScene(startingLevel);
        }
    }
}