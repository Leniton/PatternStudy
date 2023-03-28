using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Patterns.Creational.FactoryMethod
{
    public class Client_FactoryMethod : MonoBehaviour
    {
        void Start()
        {
            Creator creator = new FireSkill_Creator();

            creator.SomeOperation();
        }
    }
}
