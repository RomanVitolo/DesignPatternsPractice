namespace Core.Runtime.FactoryExample.Samples
{
    public class ParameterizedCreator
    {
        public virtual IItem Create(string itemName)
        {
            switch (itemName)
            {
                case "Normal":
                    return new Pebble();
                case "Rare":
                    return new CursedKnife();
                default:
                    return null;
            }
        }
    }
}