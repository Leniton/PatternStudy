using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Patterns.Creational.AbstractFactory
{
    public class ConcreteProduct1B : IAbstractProductB
    {
        public void ProductBFunction()
        {
            Debug.Log("Product 1B functionality");
        }

        public void ColaborativeFunctionB(IAbstractProductA productA)
        {
            Debug.Log("Colaborative 1B functionality");

            productA.ProductAFunction();
        }
    }
}