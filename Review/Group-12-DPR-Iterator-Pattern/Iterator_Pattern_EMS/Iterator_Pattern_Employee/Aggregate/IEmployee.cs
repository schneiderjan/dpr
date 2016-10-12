using Iterator_Pattern_Employee.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern_Employee.Aggregate
{
   public  interface IEmployee
    {
       IIterator CreateIterator();
    }
}
