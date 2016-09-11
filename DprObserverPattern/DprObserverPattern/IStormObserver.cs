using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprObserverPattern
{
    interface IStormObserver
    {
        void Update(StormData subject);
    }
}
