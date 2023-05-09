using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Structural.Adapter
{
    public class Target : ITarget
    {
        public string GetRequest()
        {
            return "this is the text \"123\"";
        }
    }
}