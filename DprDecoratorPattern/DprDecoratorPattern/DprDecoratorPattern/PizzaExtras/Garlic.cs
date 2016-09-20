using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern.PizzaExtras
{
    public class Garlic: Decorator
    {
        private readonly Pizza _pizza;

        public Garlic(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.Description + ", extra garlic";
        }

        public override double Cost()
        {
            return 1 + _pizza.Cost();
        }
    }
}
