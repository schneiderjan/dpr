using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Pattern_Employee.Iterator;

namespace Iterator_Pattern_Employee.Aggregate
{
    public class ICT :IEmployee
    {
        private string[] Users;

        public ICT()
        {
            Users = new[] { "Name: Shahru    Department: ICT      ID: 2234876", "Name: MhahR     Department: ICT     ID: 2234876", "Name: LaoFy     Department: ICT     ID: 2234876", "Name: Kaomy    Department: ICT     ID: 2234876" };
        }

        public IIterator CreateIterator()
        {
            return  new ICTIterator(Users);
        }
    }
}
