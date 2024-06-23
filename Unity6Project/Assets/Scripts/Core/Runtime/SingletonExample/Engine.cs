using Core.Runtime.Singleton.Samples;
using UnityEngine;         
using UnityEngine.SceneManagement;

namespace Core.Runtime.Singleton.Samples
{
    public class Engine : GenericSingleton<Engine>
    {      
        public int score = 0;
        public int startingLevel = 1;

        public void StartGame()
        {
            Debug.Log("New game has started...");
            SceneManager.LoadScene(startingLevel);
        }
    }
}
