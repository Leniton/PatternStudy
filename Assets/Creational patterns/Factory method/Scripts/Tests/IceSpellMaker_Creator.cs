using UnityEngine;

namespace Patterns.Creational.FactoryMethod.Tests
{
    public class IceSpellMaker_Creator : Creator
    {
        public override IProduct FactoryMethod()
        {
            Debug.Log("creating ice spell");
            return new IceSpell_Product();
        }
    }
}