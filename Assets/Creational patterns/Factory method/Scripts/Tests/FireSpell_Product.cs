using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Creational.FactoryMethod;

public class FireSpell_Product : IProduct
{
    public void Operation()
    {
        Debug.Log("fire spell activated");
    }
}
