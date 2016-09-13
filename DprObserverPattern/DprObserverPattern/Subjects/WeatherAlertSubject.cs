using System;
using System.Threading;
using System.Threading.Tasks;

namespace DprObserverPattern
{
    public class WeatherAlertSubject : Subject
    {
        private WeatherAlertData _weatherAlertData;
        public WeatherAlertData WeatherAlertData
        {
            get { return _weatherAlertData; }
            set
            {
                _weatherAlertData = value;
                //base is not called here;
                Notify(); 
            }
        }

        public WeatherAlertSubject() : base()
        {
            _weatherAlertData = new WeatherAlertData();
            FetchWeatherAlert__Worker();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FetchWeatherAlert__Worker()
        {
            Random rnd = new Random();
            Task.Run(() =>
            {
                while (true)
                {
                    var randomNr = rnd.Next(0, 5);
                    if (randomNr == 2)
                    {
                        WeatherAlertData = new WeatherAlertData
                        {
                            IsWeatherAlert = true,
                            Severity = "Dutch weather alert"
                        };
                    }
                    else
                    {
                        WeatherAlertData = new WeatherAlertData
                        {
                            IsWeatherAlert = false,
                            Severity = null
                        };
                    }
                    Thread.Sleep(10000);//Dutch weather happens not too frequently atm. So look for other cities :)
                }
            });
        }

        public new virtual void Notify()
        {
            foreach (var obs in Observers)
            {
                obs.Update(_weatherAlertData);
            }
        }
    }
}
