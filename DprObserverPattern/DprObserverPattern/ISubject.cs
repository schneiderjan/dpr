using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprObserverPattern
{
    public interface IPullSubject
    {
        void Attach(IPullObserver observer);
        void Detach(IPullObserver observer);
        void Notify();
    }
}
