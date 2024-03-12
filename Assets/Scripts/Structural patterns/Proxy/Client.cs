using UnityEngine;

namespace Patterns.Structural.Proxy
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            IService service = new RealService();
            Debug.Log("requesting from the real service");
            service.Request();
            Debug.Log("----------");
            service = new VirtualProxy();
            Debug.Log("requesting from proxy");
            service.Request();
            Debug.Log("requesting from proxy again");
            service.Request();
        }
    }
}
