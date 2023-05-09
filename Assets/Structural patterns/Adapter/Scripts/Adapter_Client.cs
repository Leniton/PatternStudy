using UnityEngine;

namespace Patterns.Structural.Adapter
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            Adaptee adaptee = new();
            ITarget target = new Adapter(adaptee);

            Debug.Log(target.GetRequest());

            Debug.Log(new Target().GetRequest());
        }
    }
}