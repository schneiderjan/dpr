using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprObserverPattern
{
    public interface IPushSubject
    {
        void Attach(IPushObserver observer);
        void Detach(IPushObserver observer);
        void Notify();
    }
}
