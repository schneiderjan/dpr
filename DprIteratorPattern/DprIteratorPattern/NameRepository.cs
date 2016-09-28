using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DprIteratorPattern
{
    class NameRepository: IContainer
    {
        public static string[] Names=new []{"Li", "Li"};

        public IIterator GetIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : IIterator
        {
            private int _index;
            public bool HadNext()
            {
                if(_index < Names.Length){
                    return true;
                }
                return false;
            }

            public object Next()
            {
                if (this.HadNext())
                {
                    return Names[_index++];
                }
                return null;
            }
        }
    }
}
