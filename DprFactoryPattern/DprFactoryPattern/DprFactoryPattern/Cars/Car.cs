using System.ComponentModel;
using DprFactoryPattern.CarParts;

namespace DprFactoryPattern
{
    public abstract class Car
    {
        public string Name = "Unknown";

        public IComponent Axe;
        public IComponent Hood;
        public IComponent Interior;

        public abstract string Assemble();

        public override string ToString()
        {
            var total = Axe.GetPrice() + Hood.GetPrice() + Interior.GetPrice();
            return string.Format("Volkswagen {0} with {1} ({2}€), {3} ({4}€), and {5} ({6}€) for a total of {7}€",
                Name, Axe.GetName(), Axe.GetPrice(), Hood.GetName(), Hood.GetPrice(), Interior.GetName(), Interior.GetPrice(),total);
        }

    }
}
