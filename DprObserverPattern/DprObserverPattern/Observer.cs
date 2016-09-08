using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace DprObserverPattern
{
    public class Observer: IObserver, INotifyPropertyChanged
    {
        private Subject WeatherStationSubject;
        private WeatherData _weatherDataUI;

        public WeatherData WeatherDataUi
        {
            get { return _weatherDataUI; }
            set { _weatherDataUI = value; OnPropertyChanged(); }
        }

        public Observer(Subject subject)
        {
            WeatherStationSubject = subject;
            WeatherStationSubject.Attach(this);
        }

        public void Update(WeatherData weatherData)
        {
            WeatherDataUi = weatherData;
            MessageBox.Show(WeatherDataUi.Humidity.ToString());
        }

        //ObservableCollection of string with the runningRequest; used for oxyplot
        public ObservableCollection<string> CurrectRunningProceses { get; set; }

        //OnPropertyChanged Event
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
