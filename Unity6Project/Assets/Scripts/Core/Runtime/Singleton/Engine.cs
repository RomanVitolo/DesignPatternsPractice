using Singleton;
using UnityEngine;         
using UnityEngine.SceneManagement;

namespace GameEngine
{
    public class GameEngine : GenericSingleton<GameEngine>
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
