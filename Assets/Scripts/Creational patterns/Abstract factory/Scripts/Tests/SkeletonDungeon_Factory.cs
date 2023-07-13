
namespace Patterns.Creational.AbstractFactory.Tests
{
    public class SkeletonDungeon_Factory : IAbstract_Factory
    {
        public IAbstractProductA CreateProductA()
        {
            return new SkelletonWarrior_ProductA();
        }

        public IAbstractProductB CreateProductB()
        {
            return new SkelletonKing_ProductB();
        }
    }
}