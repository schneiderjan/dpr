using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern.PizzaExtras
{
    public class Parmezan: Decorator
    {
        private readonly Pizza _pizza;

        public Parmezan(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", extra parmezan";
        }

        public override double Cost()
        {
            return 2 + _pizza.Cost();
        }
    }
}
