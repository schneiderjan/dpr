using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprFactoryPattern.Factories
{
    class HannoverFactory: IVwAbstractFactory
    {
        public void CreateHood()
        {
            throw new NotImplementedException();
        }

        public void CreateAxe()
        {
            throw new NotImplementedException();
        }

        public void CreateInterior()
        {
            throw new NotImplementedException();
        }
    }
}
