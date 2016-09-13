using System.ComponentModel;
using System.Runtime.CompilerServices;
using OpenWeatherMap;
using System.Windows;

namespace DprObserverPattern.Observers
{
    public class WeatherObserver : IObserver, INotifyPropertyChanged
    {
        private WeatherSubject _weatherSubject;
        private CurrentWeatherResponse _weatherData;

        public CurrentWeatherResponse WeatherDataUi
        {
            get { return _weatherData; }
            set
            {
                _weatherData = value;
                OnPropertyChanged();
            }
        }

        public WeatherObserver(WeatherSubject subject)
        {
            _weatherSubject = subject;
            _weatherSubject.Attach(this);
            
        }

        public void Update(object data)
        {
            if (data == null) WeatherDataUi = _weatherSubject.GetWeatherData();
        }

        //OnPropertyChanged Event
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
