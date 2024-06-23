namespace Core.Runtime.PrototypeExample.Samples
{
    public interface IPrototype
    {
        IPrototype ShallowClone();    
        IPrototype DeepClone();
    }
}