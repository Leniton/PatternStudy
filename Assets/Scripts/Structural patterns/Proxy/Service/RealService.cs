using UnityEngine;

namespace Patterns.Structural.Proxy
{
    public class RealService : IService
    {
        public void Request()
        {
            Debug.Log("Handling request");
        }
    }
}
