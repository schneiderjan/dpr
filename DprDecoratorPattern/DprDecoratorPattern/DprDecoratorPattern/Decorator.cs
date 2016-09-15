using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprDecoratorPattern
{
    public abstract class Decorator: Pizza
    {
        public abstract string GetDescription();
    }
}
