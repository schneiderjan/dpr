using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern.Pizzas
{
    public class Margerita : Pizza
    {
        public Margerita()
        {
            Description = "Margerita";
        }

        public override double Cost()
        {
            return 8.75 + base.Cost();
        }
    }
}
