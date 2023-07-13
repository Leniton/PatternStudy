using UnityEngine;
using System;

namespace Patterns.Structural.Bridge
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            abstraction.Operation();

            Debug.Log("---------------");

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            abstraction.Operation();
        }
    }
}