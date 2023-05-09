using UnityEngine;

namespace Patterns.Creational.FactoryMethod.Tests
{
    public class FireSpellMaker_Creator : Creator
    {
        public override IProduct FactoryMethod()
        {
            Debug.Log("creating fire spell");
            return new FireSpell_Product();
        }
    }
}