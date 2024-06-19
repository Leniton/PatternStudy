using UnityEngine;

namespace Patterns.Behavioral.Command
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();

            Debug.Log("Invoker with no commands:");
            invoker.Click();
            Debug.Log("-------------------------------");
            Debug.Log("Invoker with simple command:");
            invoker.SetCommand(new SimpleCommand());
            invoker.Click();
            Debug.Log("-------------------------------");
            Debug.Log("Invoker with other command:");
            invoker.SetCommand(new OtherCommand(3));
            invoker.Click();
            Debug.Log("-------------------------------");
            Debug.Log("Invoker with receiver command:");
            invoker.SetCommand(new ReceiverCommand(receiver));
            invoker.Click();
        }
    }
}
