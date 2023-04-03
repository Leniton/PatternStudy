using Patterns.Creational.AbstractFactory;

public class SlimeDungeon_Factory : IAbstract_Factory
{
    public IAbstractProductA CreateProductA()
    {
        return new Slime_ProductA();
    }

    public IAbstractProductB CreateProductB()
    {
        return new SlimeKing_ProductB();
    }
}
