using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprObserverPattern
{
    public interface IObserver
    {
        void Update(WeatherData subject);

    }
}
