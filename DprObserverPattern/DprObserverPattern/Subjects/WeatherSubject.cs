using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenWeatherMap;


namespace DprObserverPattern
{
    public class WeatherSubject : Subject
    {
        private CurrentWeatherResponse weatherData;
        private OpenWeatherMapClient weatherMapClient;

        public CurrentWeatherResponse WeatherData
        {
            get { return weatherData; }
            set
            {
                weatherData = value;
                base.Notify();
            }
        }

        public WeatherSubject() : base()
        {
            weatherData = new CurrentWeatherResponse();
            weatherMapClient = new OpenWeatherMapClient("c29ea3be75bc79b4fd54b5ea53cdd6aa");
            FetchOpenWeatherMap__Worker();
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
                     Thread.Sleep(1250);
                 }
             });
        }
    }
}
