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
        product.Add("Training room");
    }

    public void StepB()
    {
        product.Add("Weaponry");
    }

    public void StepC()
    {
        product.Add("Armory");
    }

    public Product GetProduct()
    {
        Product result = product;

        //optional
        Reset();
        result.ListParts();
        return result;
    }
}
