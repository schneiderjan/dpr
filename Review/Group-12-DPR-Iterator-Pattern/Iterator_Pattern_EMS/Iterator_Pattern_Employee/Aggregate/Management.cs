using Iterator_Pattern_Employee.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern_Employee.Aggregate
{
    public class Management : IEmployee
    {
        public LinkedList<string> Users;
        public Management()
        {
            Users = new LinkedList<string>();
            Users.AddLast("Name: Nurja      Department: Management     ID: 3456234");
            Users.AddLast("Name: Shoju      Department: Management     ID: 3788234");
            Users.AddLast("Name: Kital      Department: Management     ID: 3786734");
            Users.AddLast("Name: Pemul      Department: Management     ID: 3786734");
            Users.AddLast("Name: Qiuyl       Department: Management     ID: 3786734");
        }

        public IIterator CreateIterator()
        {
            return new ManagementIterator(Users);
        }
    }
}
