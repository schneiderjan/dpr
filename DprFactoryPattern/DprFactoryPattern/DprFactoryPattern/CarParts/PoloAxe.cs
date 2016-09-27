using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.CarParts;

namespace DprFactoryPattern.Wolfsburg
{
    public class PoloAxe: IComponent
    {
      

        public string GetName()
        {
            return "PoloAxe";
        }

        public int GetPrice()
        {
            return 6340;
        }
    }
}
