using DprFactoryPattern.CarParts;

namespace DprFactoryPattern
{
    public interface IFactory
    {
        IComponent CreateHood();
        IComponent CreateAxe();
        IComponent CreateInterior();

    }
}
