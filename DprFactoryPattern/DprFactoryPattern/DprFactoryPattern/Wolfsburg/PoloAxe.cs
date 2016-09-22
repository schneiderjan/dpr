using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprFactoryPattern.CarParts;

namespace DprFactoryPattern.Wolfsburg
{
    public class PoloAxe: IAxe
    {
        public string Name;
        public PoloAxe()
        {
            Name = "Axe type: Polo";
        }
    }
}
