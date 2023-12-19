
namespace Patterns.Structural.Facade
{
    public class Client : IClient
    {
        public void ClientFunction()
        {
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            facade.Operation();
        }
    }
}
