using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Creational.FactoryMethod;

public class IceSpellMaker_Creator : Creator
{
    public override IProduct FactoryMethod()
    {
        Debug.Log("creating ice spell");
        return new IceSpell_Product();
    }
}
