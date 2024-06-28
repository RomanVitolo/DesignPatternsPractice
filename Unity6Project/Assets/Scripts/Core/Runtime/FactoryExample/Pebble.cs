using UnityEngine;

namespace Core.Runtime.FactoryExample.Samples
{
    public class Pebble : MonoBehaviour, IItem
    {
        public void Equip()
        {
            Debug.Log($"You skipped your pebble at a nearby lake. ");
        }
    }
}