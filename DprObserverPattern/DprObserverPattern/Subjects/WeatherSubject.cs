using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenWeatherMap;


namespace DprObserverPattern
{
    public class WeatherSubject : ISubject
    {
        private List<IObserver> observers;
        private CurrentWeatherResponse weatherData;
        private OpenWeatherMapClient weatherMapClient;

        public CurrentWeatherResponse WeatherData
        {
            get { return weatherData; }
            set
            {
                weatherData = value;
                Notify();
            }
        }

        public WeatherSubject()
        {
            weatherData = new CurrentWeatherResponse();
            observers = new List<IObserver>();

            weatherMapClient = new OpenWeatherMapClient("c29ea3be75bc79b4fd54b5ea53cdd6aa");
            FetchOpenWeatherMap__Worker();
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
                obs.Update(null);
            }
        }

        public CurrentWeatherResponse GetWeatherData()
        {
            return this.weatherData;
        }

        /// <summary>
        /// Worker thread which fetches weather info from OpenWeatherMapApi
        /// </summary>
        private async void FetchOpenWeatherMap__Worker()
        {
            await Task.Run(async () =>
             {
                 while (true)
                 {
                     WeatherData = await weatherMapClient.CurrentWeather.GetByName("Eindhoven");
                     Thread.Sleep(5000);
                 }
             });

        }
    }
}
