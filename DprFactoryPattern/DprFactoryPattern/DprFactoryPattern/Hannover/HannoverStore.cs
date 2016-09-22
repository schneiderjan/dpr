using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.Factories;
using DprFactoryPattern.Wolfsburg;

namespace DprFactoryPattern.Hannover
{
    public class HannoverStore: VwStore
    {
        public override Car createCar()
        {
            IVwAbstractFactory vwFactory = new WolfsburgFactory();

            Car polo = new Golf(vwFactory);

            return polo;
        }
    }
}
