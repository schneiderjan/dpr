using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern_Employee.Iterator
{
   public interface IIterator 
    {
        void First();
        string Next();
        bool IsDone();
        string CurrentItem();
    }
}
