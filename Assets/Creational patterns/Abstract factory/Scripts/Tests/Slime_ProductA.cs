using UnityEngine;
using Patterns.Creational.AbstractFactory;

public class Slime_ProductA : IAbstractProductA
{
    public void ProductAFunction()
    {
        Debug.Log("A slime appeared!");
    }
}
