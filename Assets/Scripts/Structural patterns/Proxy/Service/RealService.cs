using UnityEngine;

namespace Patterns.Structural.Proxy
{
    public class RealService : IService
    {
        public void Request(int id)
        {
            Debug.Log($"Handling request for {id}");
        }
    }
}
