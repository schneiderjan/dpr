using System.Windows;
using DprObserverPattern.Observers;

namespace DprObserverPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WeatherObserver weatherObserver;
        private WeatherSubject weatherSubject;
        private ObserverViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            weatherSubject = new WeatherSubject();
            weatherObserver = new WeatherObserver(weatherSubject);

            _viewModel = new ObserverViewModel();
            DataContext = this;
        }
    }
}
