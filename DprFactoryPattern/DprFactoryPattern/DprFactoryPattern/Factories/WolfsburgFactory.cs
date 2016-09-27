using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.CarParts;
using DprFactoryPattern.Hannover;
using DprFactoryPattern.Wolfsburg;

namespace DprFactoryPattern.Factories
{
    class WolfsburgFactory: IFactory
    {
        public IHood CreateHood()
        {
            return new PoloHood();
        }

        public IAxe CreateAxe()
        {
            return new PoloAxe();
        }

        public IInterior CreateInterior()
        {
            return new PoloInterior(); 
        }
    }
}
