using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Patterns.Creational.AbstractFactory
{
    public class ConcreteProduct1B : IAbstractProductB
    {
        public void ProductFunctionB()
        {
            throw new System.NotImplementedException();
        }

        public void ColaborativeFunctionB(IAbstractProductA productA)
        {
            throw new System.NotImplementedException();
        }
    }
}