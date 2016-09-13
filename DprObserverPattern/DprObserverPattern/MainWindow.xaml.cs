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
        public WeatherObserver weatherObserver;
        private WeatherSubject weatherSubject;
        private ViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            weatherSubject = new WeatherSubject();
            weatherObserver = new WeatherObserver(weatherSubject);

            _viewModel = new ViewModel
            {
                Temperature = "",
                City = "",
                ObserverMainWindow = this
            };
            
            DataContext = this;
        }
    }
}
