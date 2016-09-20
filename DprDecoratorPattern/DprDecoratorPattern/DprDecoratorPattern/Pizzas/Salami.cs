using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern.Pizzas
{
    class Salami:Pizza
    {
        public Salami()
        {
            Description = "Salami";
        }

        public override double Cost()
        {
            return 12;// + base.Cost();
        }
    }
}
