using UnityEngine;

namespace Patterns.Structural.Proxy
{
    public class VirtualProxy : IService
    {
        private RealService _realService;
        //private RealService realService => _realService ?? new RealService();//neat short way to do it
        private RealService realService
        {
            get
            {
                if (_realService == null)
                {
                    Debug.Log("Lazy initialization of real service");
                    _realService = new RealService();
                }
                return _realService;
            }
        }

        public void Request(int id)
        {
            realService.Request(id);
        }
    }
}
