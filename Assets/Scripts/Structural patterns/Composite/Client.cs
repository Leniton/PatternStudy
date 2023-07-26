using UnityEngine;

namespace Patterns.Structural.Composite
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            Debug.Log("Single component");
            Component component = new Leaf();
            component.Operation();

            Debug.Log("---------------");

            Debug.Log("Composite component");
            component = new Composite();
            component.Add(new Leaf());
            Component branch = new Composite();
            branch.Add(new Leaf());
            component.Add(branch);
            component.Operation();
        }
    }
}