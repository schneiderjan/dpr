using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern.PizzaExtras
{
    public class Gorgonzola: Decorator
    {
        private readonly Pizza _pizza;

        public Gorgonzola(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.Description + ", extra gorgonzola";
        }

        public override double Cost()
        {
            return 2.5 + _pizza.Cost();
        }
    }
}
