using UnityEngine;

namespace Patterns.Structural.Proxy
{
    public class Proxy : IService
    {
        private RealService _realService;
        //private RealService realService => _realService ?? new RealService();//neat short way to do it
        private RealService realService
        {
            get
            {
                if (_realService == null)
                {
                    Debug.Log("service not available, creating one:");
                    _realService = new RealService();
                }
                return _realService;
            }
        }

        public void Request()
        {
            realService.Request();
        }
    }
}
