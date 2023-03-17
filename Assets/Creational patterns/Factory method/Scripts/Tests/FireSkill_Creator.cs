using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Creational.FactoryMethod;

public class FireSkill_Creator : Creator
{
    public override IProduct FactoryMethod()
    {
        Debug.Log("activating fire skill");
        return new FireEffect_Product();
    }
}
