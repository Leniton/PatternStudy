using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Creational.FactoryMethod;

public class IceSkill_Creator : Creator
{
    public override IProduct FactoryMethod()
    {
        Debug.Log("activating ice skill");
        return new IceEffect_Product();
    }
}
