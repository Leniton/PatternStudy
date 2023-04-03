using UnityEngine;
using Patterns.Creational.AbstractFactory;

public class SkelletonWarrior_ProductA : IAbstractProductA
{
    public void ProductAFunction()
    {
        Debug.Log("A skelleton warrior appeared!");
    }
}
