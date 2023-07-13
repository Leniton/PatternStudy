using System;

namespace Patterns.Creational.FactoryMethod
{
    public class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
