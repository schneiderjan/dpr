using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopStatePattern
{
    public class PackingState : PizzaState
    {
        Pizza pizza;

        public PackingState(Pizza p)
        {
            this.pizza = p;
        }

        public String Gathering()
        {
            return pizza.returnName() + "Product gathering was completed!";
        }

        public String Cooking()
        {
            return pizza.returnName() + "Cooking was completed!";
        }

        public String Packing()
        {
            pizza.setState(pizza.getDeliveringState());
            return pizza.returnName() + " Packing is complete!";
        }

        public String Delivering()
        {
            return pizza.returnName() + "Product delivery cannot start until packing is complete";
        }
    }
}
