using System;
using UnityEngine;

namespace Patterns.Creational.FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public void SomeOperation()
        {
            IProduct product = FactoryMethod();

            product.Operation();
            Debug.Log("something");
        }
    }
}
