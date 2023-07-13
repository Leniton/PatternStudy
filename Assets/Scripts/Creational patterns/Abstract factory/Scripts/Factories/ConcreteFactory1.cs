using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Patterns.Creational.AbstractFactory
{
    public class ConcreteFactory1 : IAbstract_Factory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProduct1A();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProduct1B();
        }
    }
}