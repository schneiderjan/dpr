using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DprObserverPattern
{
    public class WeatherAlertOberserver : IObserver, INotifyPropertyChanged
    {
        private WeatherAlertSubject _weatherAlertSubject;
        private WeatherAlerData _weatherAlerData;
        public WeatherAlerData WeatherAlerDataUi
        {
            get { return _weatherAlerData; }
            set { _weatherAlerData = value; OnPropertyChanged(); }
        }

        public WeatherAlertOberserver(WeatherAlertSubject subject)
        {
            _weatherAlertSubject = subject;
            _weatherAlertSubject.Attach(this);
        }
        public void Update(object data)
        {
            if (data is WeatherAlerData && data != null) _weatherAlerData = (WeatherAlerData)data;
        }

        #region INotifyPropertyChanged
        //OnPropertyChanged Event
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
