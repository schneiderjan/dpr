using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DprObserverPattern
{
   public class StormSubject : IPushSubject
    {
        private List<IPushObserver> observers;
        private StormData stormData;
        public StormData StormData {
            get { return stormData; }
            set
            {
                stormData = value;
                Notify();
            }
        }

        public StormSubject()
        {
            stormData = new StormData();
            observers = new List<IPushObserver>();
        }

        public void Attach(IPushObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IPushObserver observer)
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var obs in observers)
            {
                obs.Update(stormData);
            }
        }
    }
}
