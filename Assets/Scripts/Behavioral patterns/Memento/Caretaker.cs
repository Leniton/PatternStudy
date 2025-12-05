using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Behavioral.Memento
{
    public class Caretaker
    {
        private Originator originator;
        private Stack<IMemento> history;

        private IMemento currentSave;

        public Caretaker(Originator _originator)
        {
            originator = _originator;
            history = new();
            history.Push(originator.GetState());
            originator.onStateChanged += StateChanged;
        }

        private void StateChanged(IMemento memento) => history.Push(memento);

        public void Undo()
        {
            if (history.Count <= 0)
            {
                Debug.LogWarning("There's no states to undo");
                return;
            }
            originator.SetState(history.Pop());
        }

        public IMemento Save()
        {
            currentSave = originator.GetState();
            return currentSave;
        }

        public void Load(IMemento memento = null)
        {
            if (memento == null && currentSave == null)
            {
                Debug.LogWarning("There's no states to load");
                return;
            }

            originator.SetState(memento ?? currentSave);
            history.Clear();
        }
    }
}