
using UnityEngine;

namespace Patterns.Behavioral.Command
{
    public class SimpleCommand : ICommand
    {
        public void Execute()
        {
            Debug.Log("Doing");
        }
    }
}
