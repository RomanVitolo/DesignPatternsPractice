using UnityEngine;

namespace Core.Runtime.FactoryExample.Samples
{
    public class Potion : MonoBehaviour, IItem    
    {
        // 6
        public void Equip()    
        {
            var player = GameObject.FindAnyObjectByType<Player>();    
            player.SetColor(Color.red);    
            var manager = GameObject.FindAnyObjectByType<Manager>();    
            manager.HP += 5;    
            manager.Boost++;    
            Debug.Log($"Potion healed you for 5 HP!");    
        }
    }
}