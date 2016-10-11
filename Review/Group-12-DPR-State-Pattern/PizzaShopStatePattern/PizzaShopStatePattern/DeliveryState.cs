using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopStatePattern
{
    public class DeliveryState : PizzaState
    {
        private Pizza pizza;

        public DeliveryState(Pizza p)
        {
            this.pizza = p;
        }

        public String Gathering()
        {
            return pizza.returnName() + ": Product gathering is complete!";
        }

        public String Cooking()
        {
            return pizza.returnName() + ": Cooking was completed!";
        }

        public String Packing()
        {
            return pizza.returnName() + ": Packing was completed!";
        }

        public String Delivering()
        {
            return pizza.returnName() + ": Product was delivered!";
        }
    }
}
