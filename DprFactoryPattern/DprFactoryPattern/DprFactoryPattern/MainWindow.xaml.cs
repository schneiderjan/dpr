using System.Windows;
using DprFactoryPattern.Factories;
using DprFactoryPattern.Hannover;
using DprFactoryPattern.Wolfsburg;

namespace DprFactoryPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car car;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void PoloToggleButton_OnClick(object sender, RoutedEventArgs e)
        {
            car = new Polo(new WolfsburgFactory());
            
        }

        private void GolfToggleButton_OnClick(object sender, RoutedEventArgs e)
        {
            car = new Golf(new HannoverFactory());
        }

        private void ClearOrderMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            GolfToggleButton.IsChecked = false;
            PoloToggleButton.IsChecked = false;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (car == null) return;
            MessageBox.Show(car.Assemble());
            MessageBox.Show(car.ToString());
        }

        //Clear
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
