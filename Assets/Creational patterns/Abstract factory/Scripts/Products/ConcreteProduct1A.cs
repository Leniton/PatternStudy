using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Creational.AbstractFactory
{
    public class ConcreteProduct1A : IAbstractProductA
    {
        public void ProductAFunction()
        {
            Debug.Log("Product 1A functionality");
        }
    }
}