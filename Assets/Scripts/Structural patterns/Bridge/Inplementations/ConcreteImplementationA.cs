using UnityEngine;

namespace Patterns.Structural.Bridge
{
    public class ConcreteImplementationA : IImplementation
    {
        public void OperationImplementation()
        {
            Debug.Log("implementationA");
        }
    }
}