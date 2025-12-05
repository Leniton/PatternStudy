using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Behavioral.Memento
{
    public class Memento : IMemento
    {
        private string _state;

        public Memento(string state) => _state = state;

        public string GetState() => _state;
    }
}