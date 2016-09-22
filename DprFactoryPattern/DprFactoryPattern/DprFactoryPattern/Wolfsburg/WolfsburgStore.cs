using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.Factories;

namespace DprFactoryPattern.Wolfsburg
{
    public class WolfsburgStore: VwStore
    {
        public override Car createCar()
        {
            IVwAbstractFactory vwFactory = new WolfsburgFactory();

            Car polo = new Polo(vwFactory);

            return polo;
        }
    }
}
