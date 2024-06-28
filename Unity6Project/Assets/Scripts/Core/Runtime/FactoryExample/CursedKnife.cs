using UnityEngine;

namespace Core.Runtime.FactoryExample.Samples
{
    public class CursedKnife : MonoBehaviour, IItem
    {
        public void Equip()
        {
            var player = GameObject.FindAnyObjectByType<Player>();
            player.SetColor(Color.green);
            Debug.Log($"Woops, your're cursed...");
        }
    }
}