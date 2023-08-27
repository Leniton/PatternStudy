using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Patterns.Creational.FactoryMethod
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            Creator creator = new Tests.FireSpellMaker_Creator();
            creator.SomeOperation();
            Debug.Log("-------------------------");
            creator = new Tests.IceSpellMaker_Creator();
            creator.SomeOperation();
        }
    }
}
