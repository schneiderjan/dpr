using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprObserverPattern
{
    public abstract class Subject : ISubject
    {
        public List<IObserver> Observers;

        protected Subject()
        {
            Observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (Observers.Contains(observer))
                Observers.Remove(observer);
        }

        /// <summary>
        /// Standard implemenatation does the pull "method"
        /// </summary>
        public void Notify()
        {
            foreach (var obs in Observers)
            {
                obs.Update(null);
            }
        }
    }
}
