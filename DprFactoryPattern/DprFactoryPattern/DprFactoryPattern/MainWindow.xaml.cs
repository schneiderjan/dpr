using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
            //store.createCar();
            MessageBox.Show(store.createCar().Assemble());
        }

        private void ClearOrderMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            GolfToggleButton.IsChecked = false;
            PoloToggleButton.IsChecked = false;
        }

        private void HelpMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            //
        }
    }
}
