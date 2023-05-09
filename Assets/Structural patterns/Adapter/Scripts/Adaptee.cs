
namespace Patterns.Structural.Adapter
{
    public class Adaptee
    {
        public int value = 123;

        public int GetSpecificRequest()
        {
            return value;
        }
    }
}