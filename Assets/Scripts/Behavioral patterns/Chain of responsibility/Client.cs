using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            //Create handlers
            IHandler monkey = new MonkeyHandler();
            IHandler squirrel = new SquirrelHandler();
            IHandler dog = new DogHandler();

            //base data
            List<string> data = new List<string> { "Nut", "Banana", "Cup of coffee" };

            monkey.SetNext(squirrel).SetNext(dog);

            Debug.Log("Chain: Monkey > Squirrel > Dog");
            ProcessData(monkey,data);
            Debug.Log("-----------");
            Debug.Log("Subchain: Squirrel > Dog");
            ProcessData(squirrel, data);
        }

        private void ProcessData(IHandler handler, List<string> data)
        {
            foreach (var food in data)
            {
                string text = $"Client: Who wants a {food}?\n";
                //Debug.Log($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    text += $"   {result}";
                }
                else
                {
                    text += $"   {food} was left untouched.";
                }

                Debug.Log(text);
            }
        }

        private void CallHandler(IHandler handler, object data)
        {
            Debug.Log(handler.Handle(data).ToString());
        }
    }
}