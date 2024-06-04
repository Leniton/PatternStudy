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
        IClient client = new Patterns.Behavioral.ChainOfResponsibility.Client();
        client.ClientFunction();
    }
}