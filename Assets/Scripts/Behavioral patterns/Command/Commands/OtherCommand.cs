
using UnityEngine;

namespace Patterns.Behavioral.Command
{
    public class OtherCommand : ICommand
    {
        private int amount;
        public OtherCommand(int _amount)=> amount = _amount;

        public void Execute()
        {
            Debug.Log($"doing it {amount} times");
        }
    }
}
