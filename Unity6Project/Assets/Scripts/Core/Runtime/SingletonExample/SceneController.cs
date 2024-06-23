using UnityEngine;
using UnityEngine.UI;

namespace Core.Runtime.Singleton.Samples
{
    public class SceneController : MonoBehaviour
    {
        public Button start;
        void Start()
        {
            // 3
            start.onClick.AddListener(SOManager.Instance.StartGame);
        }
    }
}