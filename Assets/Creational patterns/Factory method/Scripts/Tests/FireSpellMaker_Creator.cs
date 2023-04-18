using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Creational.FactoryMethod;

public class FireSpellMaker_Creator : Creator
{
    public override IProduct FactoryMethod()
    {
        Debug.Log("creating fire spell");
        return new FireSpell_Product();
    }
}
