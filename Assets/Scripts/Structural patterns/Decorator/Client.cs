using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Structural.Decorator
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            Debug.Log("Simple component:");
            Component component = new ConcreteComponent();
            component.Operation();

            Debug.Log("---------------------------");

            Debug.Log("Decorated component:");
            Decorator decoratorA = new ConcreteDecoratorA(component);
            Decorator decoratorB = new ConcreteDecoratorB(decoratorA);
            decoratorB.Operation();
        }
    }
}