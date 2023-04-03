using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Patterns.Creational.AbstractFactory
{
    public interface IAbstractProductB
    {
        public void ProductBFunction();

        public void ColaborativeFunctionB(IAbstractProductA productA);
    }
}