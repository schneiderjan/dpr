using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprObserverPattern
{
    public class WeatherSubject : IPullSubject
    {
        private List<IPullObserver> observers;
        private WeatherData weatherData;
        public WeatherData WeatherData {
            get { return weatherData; }
            set
            {
                weatherData = value;
                Notify();
            }
        }

        public WeatherSubject()
        {
            weatherData = new WeatherData();
            observers = new List<IPullObserver>();
        }

        public void Attach(IPullObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IPullObserver observer)
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var obs in observers)
            {
                obs.Update();
            }
        }

        public WeatherData GetWeatherData()
        {
            return this.weatherData;
        }
    }
}
