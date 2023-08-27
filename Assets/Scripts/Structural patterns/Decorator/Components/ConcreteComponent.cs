using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Structural.Decorator
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Debug.Log("concrete component");
        }
    }
}