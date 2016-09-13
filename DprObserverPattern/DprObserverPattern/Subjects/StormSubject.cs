using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DprObserverPattern
{
    public class StormSubject : Subject
    {
        private StormData stormData;
        public StormData StormData
        {
            get { return stormData; }
            set
            {
                stormData = value;
                base.Notify();
            }
        }

        public StormSubject() : base()
        {
            stormData = new StormData();
        }


        public new virtual void Notify()
        {
            foreach (var obs in Observers)
            {
                obs.Update(stormData);
            }
        }
    }
}
