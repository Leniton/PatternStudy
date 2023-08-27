using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Structural.Decorator
{
    public abstract class Decorator : Component
    {
        protected Component component;

        public Decorator(Component _component) => component = _component;

        public void SetComponent(Component _component) => component = _component;
        
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
            else
            {
                Debug.Log("...");
            }
        }
    }
}