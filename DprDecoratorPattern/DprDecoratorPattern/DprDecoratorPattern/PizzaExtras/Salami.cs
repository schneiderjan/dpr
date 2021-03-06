﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern.PizzaExtras
{
    public class Salami: Decorator
    {
        private readonly Pizza _pizza;

        public Salami(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", extra garlic";
        }

        public override double Cost()
        {
            return 2 + _pizza.Cost();
        }
    }
}
