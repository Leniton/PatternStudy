using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Creational.Builder;

public class DungeonBuilder : IBuilder
{
    Product product = new();

    public DungeonBuilder()
    {
        Reset();
    }

    void Reset()
    {
        product = new();
    }

    public void StepA()
    {
        product.Add("Inner walls");
    }

    public void StepB()
    {
        product.Add("Traps");
    }

    public void StepC()
    {
        product.Add("Hidden treasure");
    }

    public Product GetProduct()
    {
        Product result = product;

        //optional
        Reset();

        return result;
    }
}
