using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Creational.AbstractFactory
{
    public class Client_AbstractFactory : MonoBehaviour
    {
        private void Start()
        {
            ClientMethod(new SkeletonDungeon_Factory());
            Debug.Log("----------------");
            ClientMethod(new SlimeDungeon_Factory());
        }

        void ClientMethod(IAbstract_Factory factory)
        {
            IAbstractProductA productA = factory.CreateProductA();

            IAbstractProductB productB = factory.CreateProductB();

            productB.ProductBFunction();
            productB.ColaborativeFunctionB(productA);
        }
    }
}