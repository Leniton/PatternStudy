
namespace Patterns.Behavioral.ChainOfResponsibility
{
    public class AbstractHandler : IHandler
    {
        private IHandler nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            nextHandler = handler;
            
            // Returning a handler from here will let us link handlers in a
            // convenient way like this:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object Handle(object request)
        {
            if(nextHandler != null)
            {
                return nextHandler.Handle(request);
            }

            return null;
        }
    }
}
