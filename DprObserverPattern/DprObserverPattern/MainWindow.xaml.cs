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
        private WeatherAlertOberserver weatherAlertOberserver;
        private WeatherAlertSubject weatherAlertSubject;

        public MainWindow()
        {
            InitializeComponent();
            weatherAlertSubject = new WeatherAlertSubject();
            weatherAlertOberserver = new WeatherAlertOberserver(weatherAlertSubject);

            weatherSubject = new WeatherSubject();
            weatherObserver = new WeatherObserver(weatherSubject);

            weatherSubject.SearchCity = "Manchester";

            DataContext = weatherObserver;
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            weatherSubject.SearchCity = CitySearchTextBox.Text;
        }
    }
}
