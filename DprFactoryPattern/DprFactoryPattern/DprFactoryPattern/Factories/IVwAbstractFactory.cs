using DprFactoryPattern.CarParts;

namespace DprFactoryPattern
{
    public interface IVwAbstractFactory
    {
        IHood CreateHood();
        IAxe CreateAxe();
        IInterior CreateInterior();

    }
}
