using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.CarParts;

namespace DprFactoryPattern.Wolfsburg
{
    public class PoloInterior : IComponent
    {
        public string GetName()
        {
            return "PoloInterior";
        }

        public int GetPrice()
        {
            return 14300;
        }
    }
}
