using DprFactoryPattern.CarParts;

namespace DprFactoryPattern
{
    public abstract class Car: IAxe, IHood, IInterior
    {
        public string Name="Unknown";

        public IAxe Axe;
        public IHood Hood;
        public IInterior Interior;

        public abstract string Assemble();
        
    }
}
