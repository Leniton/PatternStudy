using UnityEngine;

namespace Patterns.Structural.Proxy
{
    public class ProtectionProxy : IService
    {
        private RealService _realService;
        private RealService realService => _realService ?? new RealService();

        public void Request(int id)
        {
            if(id != 0)
            {
                Debug.Log("Service access denied");
                return;
            }
            realService.Request(id);
        }
    }
}
