using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Structural.Composite
{
    public class Composite : Component
    {
        protected List<Component> children = new();

        public override void Add(Component component) => children.Add(component);

        public override void Remove(Component component) => children.Remove(component);

        public override void Operation()
        {
            Debug.Log("Branch\n----------");
            for (int i = 0; i < children.Count; i++)
            {
                children[i].Operation();
            }
            Debug.Log("--End branch");
        }
    }
}