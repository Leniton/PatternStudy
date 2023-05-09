using UnityEngine;

namespace Patterns.Creational.AbstractFactory.Tests
{
    public class SlimeKing_ProductB : IAbstractProductB
    {
        public void ProductBFunction()
        {
            Debug.Log("A slime king appeared!");
        }

        public void ColaborativeFunctionB(IAbstractProductA productA)
        {
            Debug.Log("The slime king is dividing itself");

            productA.ProductAFunction();
        }
    }
}