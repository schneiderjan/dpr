using System;
using System.Windows;
using DprObserverPattern.Observers;

namespace DprObserverPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WeatherObserver WeatherObserver;
        public WeatherSubject WeatherSubject;
        public WeatherAlertOberserver WeatherAlertOberserver;
        public WeatherAlertSubject WeatherAlertSubject;


        public MainWindow()
        {
            InitializeComponent();

            WeatherAlertSubject = new WeatherAlertSubject();
            WeatherAlertOberserver = new WeatherAlertOberserver(WeatherAlertSubject);

            WeatherSubject = new WeatherSubject();
            WeatherObserver = new WeatherObserver(WeatherSubject);

            //Set by default.
            WeatherSubject.SearchCity = "Eindhoven";

            DataContext = WeatherObserver;
        }



        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            WeatherSubject.SearchCity = CitySearchTextBox.Text;
        }
    }


}
