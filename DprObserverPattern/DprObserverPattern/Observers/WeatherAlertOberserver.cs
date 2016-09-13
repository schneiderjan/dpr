using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace DprObserverPattern
{
    public class WeatherAlertOberserver : IObserver, INotifyPropertyChanged
    {
        private WeatherAlertSubject _weatherAlertSubject;
        private WeatherAlertData _weatherAlertData;
        public WeatherAlertData WeatherAlertDataUi
        {
            get { return _weatherAlertData; }
            set { _weatherAlertData = value; OnPropertyChanged(); }
        }

        public WeatherAlertOberserver(WeatherAlertSubject subject)
        {
            _weatherAlertSubject = subject;
            _weatherAlertSubject.Attach(this);
        }
        public void Update(object data)
        {
            if (data is WeatherAlertData && data != null)
            {
                _weatherAlertData = (WeatherAlertData)data;
                MessageBox.Show("Extreme weather! " + _weatherAlertData.Severity);
            }
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
