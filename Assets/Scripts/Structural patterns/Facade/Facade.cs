

using UnityEngine;

namespace Patterns.Structural.Facade
{
    public class Facade
    {
        protected Subsystem1 subsystem1;
        protected Subsystem2 subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this.subsystem1 = subsystem1;
            this.subsystem2 = subsystem2;
        }

        public void Operation()
        {
            Debug.Log("facade simplifying subsystem operations");
            subsystem1.operation1();
            subsystem2.operation1();
            Debug.Log("next operations");
            subsystem1.operation2();
            subsystem2.operation2();
        }
    }
}
