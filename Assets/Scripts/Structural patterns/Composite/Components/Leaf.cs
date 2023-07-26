using UnityEngine;

namespace Patterns.Structural.Composite
{
    public class Leaf : Component
    {
        public override void Operation()
        {
            Debug.Log("Leaf");
        }
    }
}