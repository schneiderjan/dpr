using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern
{
    public class Funghi : Pizza
    {
        public Funghi()
        {
            Description = "Funghi";
        }

        public override double Cost()
        {
            return 11.50;// + base.Cost();
        }
    }
}
