using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DprObserverPattern
{
   public class StormSubject : ISubject
    {
        private List<IObserver> observers;
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
            observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
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
