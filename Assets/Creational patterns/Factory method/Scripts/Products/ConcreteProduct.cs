using System;
using UnityEngine;

namespace Patterns.Creational.FactoryMethod
{
    public class ConcreteProduct : IProduct
    {
        public void Operation()
        {
            Debug.Log("product operation");
        }
    }
}
