using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Structural.Proxy
{
    public class LoggingProxy : IService
    {
        private RealService _realService;
        private RealService realService => _realService ?? new RealService();

        List<int> logs = new();

        public void Request(int id)
        {
            Debug.Log($"Saving {id} request on log");
            logs.Add(id);
            realService.Request(id);
        }

        public void GetLog()
        {
            string result = "Requests:";
            for (int i = 0; i < logs.Count; i++)
            {
                result += $"\nRequest from {logs[i]}";
            }
            Debug.Log(result);
        }
    }
}
