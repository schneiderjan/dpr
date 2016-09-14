using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern.Pizzas
{
    class Verdura: Pizza
    {
        public Verdura()
        {
            Description = "Verdura";
        }

        public override double Cost()
        {
            return 10.25 + base.Cost();
        }
    }
}
