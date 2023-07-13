using UnityEngine;

namespace Patterns.Structural.Bridge
{
    public class ConcreteImplementationB : IImplementation
    {
        public void OperationImplementation()
        {
            Debug.Log("implementationB");
        }
    }
}