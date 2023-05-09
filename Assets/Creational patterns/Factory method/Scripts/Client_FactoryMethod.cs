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
            Creator creator = new FireSpellMaker_Creator();

            creator.SomeOperation();
        }
    }
}
