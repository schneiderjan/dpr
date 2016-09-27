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
        private VwStore store;
        private IVwAbstractFactory factory;
        public MainWindow()
        {
            InitializeComponent();

            factory = new HannoverFactory();
        }

        private void PoloToggleButton_OnClick(object sender, RoutedEventArgs e)
        {
            store = new WolfsburgStore();
            //store.createCar();
            MessageBox.Show(store.createCar().Assemble());

        }

        private void GolfToggleButton_OnClick(object sender, RoutedEventArgs e)
        {
            store= new HannoverStore();
            MessageBox.Show(store.createCar().Assemble());
        }

        private void ClearOrderMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            GolfToggleButton.IsChecked = false;
            PoloToggleButton.IsChecked = false;
        }

        private void HelpMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            //Show manual
        }
    }
}
