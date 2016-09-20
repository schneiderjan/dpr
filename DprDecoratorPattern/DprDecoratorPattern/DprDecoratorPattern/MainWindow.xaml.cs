using System;
using System.Diagnostics;
using System.Windows;
using DprDecoratorPattern.PizzaExtras;
using DprDecoratorPattern.Pizzas;
using Salami = DprDecoratorPattern.Pizzas.Salami;

namespace DprDecoratorPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pizza _pizza;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckBox1.IsChecked != null && (bool) CheckBox1.IsChecked) _pizza = new Garlic(_pizza);
                if (CheckBox2.IsChecked != null && (bool) CheckBox2.IsChecked) _pizza=new PizzaExtras.Salami(_pizza);
                if (CheckBox3.IsChecked != null && (bool) CheckBox3.IsChecked) _pizza = new Rucola(_pizza);
                if (CheckBox4.IsChecked != null && (bool) CheckBox4.IsChecked) _pizza=new Gorgonzola(_pizza);
                if (CheckBox5.IsChecked != null && (bool) CheckBox5.IsChecked) _pizza=new Parmezan(_pizza);

                MessageBox.Show("You ordered " + _pizza.GetDescription() + " for " + _pizza.Cost()+"€");

                Button1.IsChecked = false;
                Button2.IsChecked = false;
                Button3.IsChecked = false;
                Button4.IsChecked = false;
                _pizza = null;
                CheckBox1.IsChecked = false;
                CheckBox2.IsChecked = false;
                CheckBox3.IsChecked = false;
                CheckBox4.IsChecked = false;
                CheckBox5.IsChecked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a pizza!");
            }
           
        }

        private void ButtonBase1_OnClick(object sender, RoutedEventArgs e)
        {
            _pizza = new Margerita();
        }

        private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            _pizza = new Verdura();
        }

        private void ButtonBase3_OnClick(object sender, RoutedEventArgs e)
        {
            _pizza = new Funghi();
        }

        private void ButtonBase4_OnClick(object sender, RoutedEventArgs e)
        {
            _pizza=new Salami();
        }

        private void Button1_OnChecked(object sender, RoutedEventArgs e)
        {
            Button2.IsChecked = false;
            Button3.IsChecked = false;
            Button4.IsChecked = false;

        }

        private void Button2_OnChecked(object sender, RoutedEventArgs e)
        {
            Button1.IsChecked = false;
            Button3.IsChecked = false;
            Button4.IsChecked = false;
        }

        private void Button3_OnChecked(object sender, RoutedEventArgs e)
        {
            Button2.IsChecked = false;
            Button1.IsChecked = false;
            Button4.IsChecked = false;
        }

        private void Button4_OnChecked(object sender, RoutedEventArgs e)
        {
            Button2.IsChecked = false;
            Button3.IsChecked = false;
            Button1.IsChecked = false;
        }
    }
}
