using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern
{
    public abstract class Pizza
    {
        public string Description = "";

        public string GetDesctipiton()
        {
            return Description;
        }

        public virtual double Cost()
        {
            var cost=0;
            return cost;
        }
    }
}
