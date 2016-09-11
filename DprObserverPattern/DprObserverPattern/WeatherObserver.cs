using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace DprObserverPattern
{
    public class WeatherObserver: IPullObserver, INotifyPropertyChanged
    {
        private WeatherSubject weatherSubject;
        private WeatherData _weatherData;

        public WeatherData WeatherDataUi
        {
            get { return _weatherData; }
            set { _weatherData = value; OnPropertyChanged(); }
        }

        public WeatherObserver(WeatherSubject subject)
        {
            weatherSubject = subject;
            weatherSubject.Attach(this);
        }

        public void Update()
        {
           WeatherDataUi = weatherSubject.GetWeatherData();
        }

        //OnPropertyChanged Event
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
