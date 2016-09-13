using System.Windows;

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

            //weatherSubject.WeatherData = new WeatherData
            //{
            //    Temperature = 25,
            //    Pressure = 0,
            //    Humidity = 100,
            //};

        }
    }
}
