using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopStatePattern
{
    public class Pizza
    {
        static PizzaState productGathering;
        static PizzaState cooking;
        static PizzaState packing;
        static PizzaState delivery;
        PizzaState currentState;
        private String pizzaName;

        public Pizza(String pName)
        {
            pizzaName = pName;
            productGathering = new ProductGatheringState(this);
            cooking = new CookingState(this);
            packing = new PackingState(this);
            delivery = new DeliveryState(this);
            currentState = productGathering;
        }
        
        public String returnName()
        {
            return pizzaName.ToString();
        }
        public PizzaState getState()
        {
            return currentState;
        }

        public void setState(PizzaState state)
        {
            this.currentState = state;
        }

        public String Cook()
        {
            return this.currentState.Cooking();
        }

        public String Gather()
        {
            return this.currentState.Gathering();
        }

        public String Pack()
        {
            return this.currentState.Packing();
        }

        public String Deliver()
        {
            return this.currentState.Delivering();
        }
        public PizzaState getGatherState()
        {
            return productGathering;
        }
        public PizzaState getCookingState()
        {
            return cooking;
        }
        public PizzaState getPackingState()
        {
            return packing;
        }
        public PizzaState getDeliveringState()
        {
            return delivery;
        }


    }
}
