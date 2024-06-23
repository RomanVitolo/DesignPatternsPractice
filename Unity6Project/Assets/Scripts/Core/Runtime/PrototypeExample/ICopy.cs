using UnityEngine;

namespace Core.Runtime.PrototypeExample.Samples
{
    public interface ICopy
    {
        public ICopy Copy(Transform parent);
    }
}