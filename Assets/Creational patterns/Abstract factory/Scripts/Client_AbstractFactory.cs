using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Creational.AbstractFactory
{
    public class Client_AbstractFactory : MonoBehaviour
    {
        private void Start()
        {
            ClientMethod(new ConcreteFactory1());

            ClientMethod(new ConcreteFactory2());
        }

        void ClientMethod(IAbstract_Factory factory)
        {
            IAbstractProductA productA = factory.CreateProductA();

            IAbstractProductB productB = factory.CreateProductB();

            productB.ProductFunctionB();
            productB.ColaborativeFunctionB(productA);
        }
    }
}