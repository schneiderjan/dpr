using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern
{
    public abstract class Pizza
    {
        public string Description = "Unknown";

        public bool ExtraGarlic;
        public bool ExtraRucola;
        public bool ExtraGorgonzola;
        public bool ExtraSalami;
        public bool ExtraParmezan;

        public string GetDesctipiton()
        {
            return Description;
        }

        public virtual double Cost()
        {
            var cost = 0.0;

            if (ExtraGarlic) cost += 1;

            if (ExtraRucola) cost += 1.5;

            if (ExtraGorgonzola) cost += 2.5;

            if (ExtraSalami) cost += 2;

            if (ExtraParmezan) cost += 2;
            
            return cost;
        }
    }
}
