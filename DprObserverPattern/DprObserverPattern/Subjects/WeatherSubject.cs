using System.Threading;
using System.Threading.Tasks;
using OpenWeatherMap;

namespace DprObserverPattern
{
    public class WeatherSubject : Subject
    {
        private readonly OpenWeatherMapClient _weatherMapClient;

        public string SearchCity { get; set; }

        private CurrentWeatherResponse _weatherData;
        public CurrentWeatherResponse WeatherData
        {
            get { return _weatherData; }
            set
            {
                _weatherData = value;
                base.Notify();
            }
        }

        public WeatherSubject() : base()
        {
            _weatherData = new CurrentWeatherResponse();
            _weatherMapClient = new OpenWeatherMapClient("c29ea3be75bc79b4fd54b5ea53cdd6aa");
            FetchOpenWeatherMap__Worker();
        }

        public CurrentWeatherResponse GetWeatherData()
        {
            return this._weatherData;
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
                     WeatherData = await _weatherMapClient.CurrentWeather.GetByName(SearchCity);
                     Thread.Sleep(50000);
                 }
             });
        }

      
    }
}
