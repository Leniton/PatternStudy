using UnityEngine;

namespace Patterns.Creational.AbstractFactory.Tests
{
    public class SkelletonWarrior_ProductA : IAbstractProductA
    {
        public void ProductAFunction()
        {
            Debug.Log("A skelleton warrior appeared!");
        }
    }
}