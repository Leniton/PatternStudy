using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Creational.FactoryMethod;

public class FireEffect_Product : IProduct
{
    public void Operation()
    {
        Debug.Log("fire effect activated");
    }
}
