using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern.PizzaExtras
{
    public class Rucola: Decorator
    {
        private readonly Pizza _pizza;

        public Rucola(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", extra rucola";
        }

        public override double Cost()
        {
            return 1.5 + _pizza.Cost();
        }
    }
}
