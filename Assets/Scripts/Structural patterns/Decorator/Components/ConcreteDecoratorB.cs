using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Structural.Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component _component) : base(_component)
        {
        }

        public override void Operation()
        {
            Debug.Log("concrete decorator B");
            base.Operation();
        }
    }
}