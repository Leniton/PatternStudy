using UnityEngine;

namespace Patterns.Structural.Bridge
{
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation) 
        {
        }
        public override void Operation()
        {
            Debug.Log("ExtendedOperation");
            base.Operation();
        }
    }
}