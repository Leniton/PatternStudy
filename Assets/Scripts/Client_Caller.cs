using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns;

public class Client_Caller : MonoBehaviour
{
    private void Start()
    {
        Call_Client();
    }

    public void Call_Client()
    {
        IClient client = new Patterns.Structural.Adapter.Client();

        client.ClientFunction();
    }
}
