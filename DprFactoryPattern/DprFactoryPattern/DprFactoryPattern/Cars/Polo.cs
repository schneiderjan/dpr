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
        public Polo(IFactory vwFactory) : base(vwFactory)
        {
            Name = "Polo";
        }
    }
}
