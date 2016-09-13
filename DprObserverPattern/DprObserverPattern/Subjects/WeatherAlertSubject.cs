using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DprObserverPattern
{
    public class WeatherAlertSubject : Subject
    {
        private WeatherAlerData _weatherAlerData;
        public WeatherAlerData WeatherAlerData
        {
            get { return _weatherAlerData; }
            set
            {
                _weatherAlerData = value;
                //base is not called here;
                Notify(); 
            }
        }

        public WeatherAlertSubject() : base()
        {
            _weatherAlerData = new WeatherAlerData();
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
                    var randomNr = rnd.Next(0, 3);
                    if (randomNr == 2)
                    {
                        WeatherAlerData = new WeatherAlerData
                        {
                            IsWeatherAlert = true,
                            Severity = "Dutch weather alert"
                        };
                    }
                    else
                    {
                        WeatherAlerData = new WeatherAlerData
                        {
                            IsWeatherAlert = false,
                            Severity = null
                        };
                    }
                    Thread.Sleep(2000);//Dutch weather happens not too frequently atm.
                }
            });
        }

        public new virtual void Notify()
        {
            foreach (var obs in Observers)
            {
                obs.Update(_weatherAlerData);
            }
        }
    }
}
