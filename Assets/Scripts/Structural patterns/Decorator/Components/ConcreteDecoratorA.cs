using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Structural.Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component _component) : base(_component)
        {
        }

        public override void Operation()
        {
            Debug.Log("concrete decorator A");
            base.Operation();
        }
    }
}