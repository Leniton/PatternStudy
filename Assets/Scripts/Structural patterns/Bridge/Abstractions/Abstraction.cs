using UnityEngine;

namespace Patterns.Structural.Bridge
{
    public class Abstraction
    {
        IImplementation _implementation;
        public Abstraction(IImplementation implementation) => _implementation = implementation;

        public virtual void Operation()
        {
            Debug.Log("abstraction");
            _implementation.OperationImplementation();
        }
    }
}