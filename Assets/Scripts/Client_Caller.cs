using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns;

public class Client_Caller : MonoBehaviour
{
    private void Start()
    {
        IClient client = new Patterns.Creational.FactoryMethod.Client_FactoryMethod();

        client.ClientFunction();
    }
}
