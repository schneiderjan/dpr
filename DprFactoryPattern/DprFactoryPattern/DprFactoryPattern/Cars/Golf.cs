using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprFactoryPattern.Hannover
{
    public class Golf: Car
    {
        public Golf(IFactory vwFactory) : base(vwFactory)
        {
            Name = "Golf";
        }
    }
}
