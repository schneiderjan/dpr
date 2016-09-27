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
    public class WolfsburgFactory: IFactory
    {
        public IComponent CreateHood()
        {
            return new PoloHood();
        }

        public IComponent CreateAxe()
        {
            return new PoloAxe();
        }

        public IComponent CreateInterior()
        {
            return new PoloInterior(); 
        }
    }
}
