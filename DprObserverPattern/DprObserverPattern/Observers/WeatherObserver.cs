using System.ComponentModel;
using System.Runtime.CompilerServices;
using OpenWeatherMap;

namespace DprObserverPattern.Observers
{
    public class WeatherObserver : IObserver, INotifyPropertyChanged
    {
        private readonly WeatherSubject _weatherSubject;

        private CurrentWeatherResponse _weatherDataUi;
        public CurrentWeatherResponse WeatherDataUi
        {
            get { return _weatherDataUi; }
            set
            {
                _weatherDataUi = value;
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

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
