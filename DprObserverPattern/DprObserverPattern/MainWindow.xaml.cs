using System.Windows;
using DprObserverPattern.Observers;
using OpenWeatherMap;

namespace DprObserverPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WeatherObserver weatherObserver;
        private WeatherSubject weatherSubject;

        public MainWindow()
        {
            InitializeComponent();
            weatherSubject = new WeatherSubject();
            weatherObserver = new WeatherObserver(weatherSubject);
            
            DataContext = new CurrentWeatherResponse();
        }
    }
}
