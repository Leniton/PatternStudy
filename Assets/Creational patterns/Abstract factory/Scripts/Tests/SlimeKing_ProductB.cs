using UnityEngine;
using Patterns.Creational.AbstractFactory;

public class SlimeKing_ProductB : IAbstractProductB
{
    public void ProductBFunction()
    {
        Debug.Log("A slime king appeared!");
    }

    public void ColaborativeFunctionB(IAbstractProductA productA)
    {
        Debug.Log("The slime king is dividing itself");

        productA.ProductAFunction();
    }
}
