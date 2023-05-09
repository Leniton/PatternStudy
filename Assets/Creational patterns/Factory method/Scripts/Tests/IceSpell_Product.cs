using UnityEngine;

namespace Patterns.Creational.FactoryMethod.Tests
{
    public class IceSpell_Product : IProduct
    {
        public void Operation()
        {
            Debug.Log("ice spell activated");
        }
    }
}