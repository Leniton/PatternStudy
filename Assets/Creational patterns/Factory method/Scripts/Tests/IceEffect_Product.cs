using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Creational.FactoryMethod;

public class IceEffect_Product : IProduct
{
    public void Operation()
    {
        Debug.Log("ice effect activated");
    }
}
