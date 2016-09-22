using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprFactoryPattern
{
    interface IVwAbstractFactory
    {
        void CreateHood();
        void CreateAxe();
        void CreateInterior();

    }
}
