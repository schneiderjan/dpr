using System.Windows;

namespace DprObserverPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WeatherStation WeatherStation;
        private Observer Observer;

        public MainWindow()
        {
            InitializeComponent();

            WeatherStation=new WeatherStation();
            Observer = new Observer(WeatherStation);

            WeatherStation.SetMeasurement(new WeatherData
            {
                Degrees = new Degrees
                {
                    Temperature = 27.5f, Unit = "Celsius"
                },
                Humidity = 90,
                Pressure = 75
            });
            
        }
    }
}
