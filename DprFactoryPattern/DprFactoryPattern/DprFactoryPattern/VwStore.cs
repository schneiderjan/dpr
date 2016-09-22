using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprFactoryPattern
{
    public abstract class VwStore
    {
        public abstract Car createCar();
    }
}
