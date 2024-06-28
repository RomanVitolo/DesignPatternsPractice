using UnityEngine;
using UnityEngine.UI;

namespace Core.Runtime.FactoryExample.Samples
{
    public class ItemButton : MonoBehaviour
    {
        public void Configure(IItem item)
        {
            this.gameObject.name = $"{item.GetType().Name} (UI)";

            var button = GetComponent<Button>();
           button.onClick.AddListener(item.Equip);

            var text = GetComponentInChildren<Text>();
            text.text = $"{item.GetType().Name} (Item)";
        }
    }
}