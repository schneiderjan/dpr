using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern_Employee.Iterator
{
    public class ManagementIterator : IIterator
    {
        public LinkedList<String> Users;
        private int position;
        public ManagementIterator(LinkedList<String> users)
        {
            this.Users = users;
            position = 0;
        }

        public string CurrentItem()
        {
            return Users.ElementAt(position);
        }

        public void First()
        {
            position = 0;
        }

        public bool IsDone()
        {
            return position >= Users.Count();
        }

        public String Next()
        {
            return Users.ElementAt(position++);
        }
    }
}
