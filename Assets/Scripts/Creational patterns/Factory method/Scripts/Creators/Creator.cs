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

            //Debug.Log("creator operation");
            product.Operation();
        }
    }
}
