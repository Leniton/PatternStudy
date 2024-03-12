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

            Debug.Log("----------");

            LoggingProxy logger = new LoggingProxy();
            Debug.Log("making requests from logging proxy");
            logger.Request(0);
            logger.Request(1);
            logger.Request(0);
            Debug.Log("retrieving logs:");
            logger.GetLog();

            /*
             * Remote proxy handles the network aspect if the service comes from a remote server
             */

            /*
             * Cashing proxy saves data that don't change often to avoid too many requests on the service
             */
        }
    }
}
