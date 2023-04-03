using UnityEngine;
using Patterns.Creational.AbstractFactory;

public class SkelletonKing_ProductB : IAbstractProductB
{
    public void ProductBFunction()
    {
        Debug.Log("A skelleton king appeared!");
    }

    public void ColaborativeFunctionB(IAbstractProductA productA)
    {
        Debug.Log("The skelleton king is summoning an underling");

        productA.ProductAFunction();
    }
}
