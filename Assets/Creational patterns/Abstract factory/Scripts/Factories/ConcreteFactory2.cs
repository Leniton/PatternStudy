using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Creational.AbstractFactory
{
    public class ConcreteFactory2 : IAbstract_Factory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProduct2A();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProduct2B();
        }
    }
}