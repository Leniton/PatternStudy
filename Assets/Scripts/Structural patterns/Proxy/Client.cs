using UnityEngine;

namespace Patterns.Structural.Proxy
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            IService service = new RealService();
            Debug.Log("requesting from the real service");
            service.Request(0);

            Debug.Log("----------");

            service = new VirtualProxy();
            Debug.Log("requesting from virtual proxy");
            service.Request(0);
            Debug.Log("requesting from virtual proxy again");
            service.Request(0);

            Debug.Log("----------");

            service = new ProtectionProxy();
            Debug.Log("requesting from protection proxy");
            service.Request(0);
            Debug.Log("requesting from protection proxy with different id");
            service.Request(1);
        }
    }
}
