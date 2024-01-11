using Newtonsoft.Json;
using System;
using UnityEngine;

namespace Patterns.Structural.Flyweight
{
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            _sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(_sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            Debug.Log($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}
