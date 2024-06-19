
namespace Patterns.Behavioral.Command
{
    public class ReceiverCommand : ICommand
    {
        private Receiver receiver;
        public ReceiverCommand(Receiver _receiver) =>receiver = _receiver;

        public void Execute()
        {
            receiver.Something();
        }
    }
}
