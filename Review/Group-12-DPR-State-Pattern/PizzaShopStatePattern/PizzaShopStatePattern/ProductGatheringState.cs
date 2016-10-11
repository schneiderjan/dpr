using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopStatePattern
{
    public class ProductGatheringState : PizzaState
    {
        private Pizza pizza;

        public ProductGatheringState(Pizza p)
        {
            this.pizza = p;
        }
        public String Gathering()
        {
            pizza.setState(pizza.getCookingState());
            return pizza.returnName() + ": Product gathering is complete!";
        }

        public String Cooking()
        {
            return pizza.returnName() + ": Cooking cannot start until gathering is complete";
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
