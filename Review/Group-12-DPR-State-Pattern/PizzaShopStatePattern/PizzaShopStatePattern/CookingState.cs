using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopStatePattern
{
    public class CookingState : PizzaState
    {
        private Pizza pizza;

        public CookingState(Pizza p)
        {
            this.pizza = p;
        }
        public String Gathering()
        {
            return pizza.returnName() + ": Product gathering was completed!";
        }

        public String Cooking()
        {
            pizza.setState(pizza.getPackingState());
            return pizza.returnName() + ": Cooking is complete!";            
        }

        public String Packing()
        {
            return pizza.returnName() + ": Packing cannot start until cooking is complete";
        }

        public String Delivering()
        {
            return pizza.returnName() + ": Product delivery cannot start until packing is complete";
        }
    }
}
