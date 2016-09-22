using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.Factories;

namespace DprFactoryPattern.Wolfsburg
{
    public class Polo: Car
    {
        private IVwAbstractFactory vwFactory;

        public Polo(IVwAbstractFactory vwFactory)
        {
            this.vwFactory = vwFactory;
            Name = "Polo";
        }

        public override string Assemble()
        {
            Hood = vwFactory.CreateHood();
            Axe = vwFactory.CreateAxe();
            Interior = vwFactory.CreateInterior();

            return "Preparing " + Name;
        }
    }
}
