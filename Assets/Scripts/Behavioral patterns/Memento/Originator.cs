using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Patterns.Behavioral.Memento
{
    public class Originator
    {
        private string state;

        public event Action<IMemento> onStateChanged;

        public Originator(string startingState) => state = startingState;

        public void DoSomething()
        {
            state = Random.Range(0, 10).ToString();
            Debug.Log($"State is now {state}");
            onStateChanged?.Invoke(GetState());
        }

        public void SetState(IMemento state)
        {
            if(state is not Memento memento) return;
            this.state = memento.GetState();
            Debug.Log($"State restored to {this.state}");
        }

        public IMemento GetState() => new Memento(state);
    }
}