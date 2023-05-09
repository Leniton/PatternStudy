using UnityEngine;

namespace Patterns.Creational.AbstractFactory.Tests
{
    public class SkelletonKing_ProductB : IAbstractProductB
    {
        public void ProductBFunction()
        {
            Debug.Log("A skelleton king appeared!");
        }

        public void ColaborativeFunctionB(IAbstractProductA productA)
        {
            Debug.Log("The skelleton king is summoning an underling");

            productA.ProductAFunction();
        }
    }
}