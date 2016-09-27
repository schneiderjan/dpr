using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.CarParts;

namespace DprFactoryPattern.Wolfsburg
{
    public class PoloHood: IComponent
    {
        

        public string GetName()
        {
            return "PoloHood";
        }

        public int GetPrice()
        {
            return 9650;
        }
    }
}
