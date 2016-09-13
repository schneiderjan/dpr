using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprObserverPattern
{
    public abstract class Observer : IObserver
    {
        Subject subject;

        public Observer (Subject subject)
        {

        }
        public void Update(object data)
        {
            throw new NotImplementedException();
        }
    }
}
