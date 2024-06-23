using Core.Runtime.Singleton.Data;
using GameEngine;
using UnityEngine;

public class Item : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"){
            // 1
            SOManager.Instance.score++;
            Destroy(this.gameObject);
            Debug.Log("Item collected!");
        }
    }
}