using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Patterns.Creational.AbstractFactory
{
    public class ConcreteProduct2B : IAbstractProductB
    {
        public void ProductFunctionB()
        {
            Debug.Log("Product 2B functionality");
        }

        public void ColaborativeFunctionB(IAbstractProductA productA)
        {
            Debug.Log("Colaborative 2B functionality");

            productA.ProductFunctionA();
        }
    }
}