using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DprObserverPattern
{
    public abstract class Subject : ISubject
    {
        public List<IObserver> Observers;
        public WeatherData WeatherData;

        protected Subject()
        {
            Observers = new List<IObserver>();
            WeatherData = new WeatherData();
        }

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (Observers.IndexOf(observer) >= 0)
            {
                Observers.RemoveAt(Observers.IndexOf(observer));
            }
        }

        public void SetMeasurement(WeatherData weatherData)
        {
            WeatherData = weatherData;
            foreach (var obs in Observers)
            {
                IObserver observer = obs;
                observer.Update(WeatherData);
            }
        }
    }
}
