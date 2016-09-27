using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprFactoryPattern.Hannover
{
    public class Golf: Car
    {
        private IFactory vwFactory;

        public Golf(IFactory vwFactory)
        {
            this.vwFactory = vwFactory;
            Name = "Golf";
        }

        public override string Assemble()
        {
            Hood = vwFactory.CreateHood();
            Axe = vwFactory.CreateAxe();
            Interior = vwFactory.CreateInterior();
            return "Assembling " + Name;
        }
    }
}
