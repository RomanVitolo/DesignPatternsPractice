using UnityEngine;

namespace Core.Runtime.Singleton.Samples
{
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
}
