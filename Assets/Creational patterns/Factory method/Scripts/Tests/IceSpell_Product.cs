using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Creational.FactoryMethod;

public class IceSpell_Product : IProduct
{
    public void Operation()
    {
        Debug.Log("ice spell activated");
    }
}
