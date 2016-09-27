using DprFactoryPattern.CarParts;

namespace DprFactoryPattern
{
    public interface IFactory
    {
        IHood CreateHood();
        IAxe CreateAxe();
        IInterior CreateInterior();

    }
}
