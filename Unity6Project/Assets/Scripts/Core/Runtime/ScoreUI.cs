using Core.Runtime.Singleton.Data;    
using UnityEngine;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour
{
    public Text score;
    void Start()
    {
        // 1
        score.text += SOManager.Instance.score;    
    }
    void Update()
    {
        // 2
        score.text = "Score: " + SOManager.Instance.score;    
    }
}