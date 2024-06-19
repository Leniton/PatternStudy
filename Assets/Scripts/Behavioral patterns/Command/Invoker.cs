
namespace Patterns.Behavioral.Command
{
    public class Invoker
    {
        private ICommand onClickCommand;

        public void SetCommand(ICommand command) => onClickCommand = command;

        public void Click() => onClickCommand?.Execute();
    }
}