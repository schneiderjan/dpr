using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Pattern_Employee.Iterator;

namespace Iterator_Pattern_Employee.Aggregate
{
    public class HR : IEmployee
    {
        public LinkedList<string> Users;

        public HR()
        {
            Users = new LinkedList<string>();
            Users.AddLast("Name: Katrina     Department: HR     ID: 1234876");
            Users.AddLast("Name: Priyana    Department: HR     ID: 1898765");
            Users.AddLast("Name: Deepika   Department: HR     ID: 1987433");
            Users.AddLast("Name: Leenima   Department: HR     ID: 1987433");
        }

        public IIterator CreateIterator()
        {
            return new HRIterator(Users);
        }
    }
}
