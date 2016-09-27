using DprFactoryPattern.CarParts;

namespace DprFactoryPattern
{
    public abstract class Car
    {
        public string Name = "Unknown";

        public IAxe Axe;
        public IHood Hood;
        public IInterior Interior;

        public abstract string Assemble();

        public override string ToString()
        {
            return string.Format("Volkswagen {0} with {1}, {2}, and {3}", Name, Axe.GetName(), Hood.GetName(), Interior.GetName());
        }

    }
}
