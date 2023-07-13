using UnityEngine;

namespace Patterns.Creational.FactoryMethod.Tests
{
    public class FireSpell_Product : IProduct
    {
        public void Operation()
        {
            Debug.Log("fire spell activated");
        }
    }
}