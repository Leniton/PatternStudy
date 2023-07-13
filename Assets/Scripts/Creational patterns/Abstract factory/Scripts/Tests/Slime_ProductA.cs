using UnityEngine;

namespace Patterns.Creational.AbstractFactory.Tests
{
    public class Slime_ProductA : IAbstractProductA
    {
        public void ProductAFunction()
        {
            Debug.Log("A slime appeared!");
        }
    }
}