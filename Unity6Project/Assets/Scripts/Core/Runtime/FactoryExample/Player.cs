using UnityEngine;

namespace Core.Runtime.FactoryExample.Samples
{
    public class Player : MonoBehaviour
    {
        public void SetColor(Color newColor)
        {
            var renderer = GetComponent<Renderer>();
            renderer.material.SetColor("_Color", newColor);
        }
    }
}