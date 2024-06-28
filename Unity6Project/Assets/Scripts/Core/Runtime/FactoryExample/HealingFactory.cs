namespace Core.Runtime.FactoryExample.Samples
{
    public class HealingFactory : ConcreteCreator
    {
        public override IItem NormalItem()
        {
            return new Potion();
        }

        public override IItem RareItem()
        {
            return new Potion();
        }

        public override IItem HealingItem()
        {
            return new Potion();
        }
    }

    public class KnifeFactory : ConcreteCreator
    {
        
    }
}