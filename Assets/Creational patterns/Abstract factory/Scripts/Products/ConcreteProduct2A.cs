using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Patterns.Creational.AbstractFactory
{
    public class ConcreteProduct2A : IAbstractProductA
    {
        public void ProductAFunction()
        {
            Debug.Log("Product 2A functionality");
        }
    }
}