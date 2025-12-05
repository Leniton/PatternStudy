using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Behavioral.Memento
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            Originator originator = new(string.Empty);
            Caretaker caretaker = new(originator);
            IMemento startState = caretaker.Save();
            
            Debug.Log("Simple Do/Undo:");
            originator.DoSomething();
            originator.DoSomething();
            originator.DoSomething();
            Debug.Log("Undoing:");
            caretaker.Undo();
            caretaker.Undo();
            caretaker.Undo();
            Debug.Log("-----------------------");
            Debug.Log("Simple Save/Load:");
            originator.DoSomething();
            originator.DoSomething();
            Debug.Log("Saving:");
            caretaker.Save();
            originator.DoSomething();
            originator.DoSomething();
            Debug.Log("Loading save:");
            caretaker.Load();
        }
    }
}