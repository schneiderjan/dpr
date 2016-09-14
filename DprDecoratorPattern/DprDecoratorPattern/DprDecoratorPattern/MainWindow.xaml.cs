using System;
using System.Diagnostics;
using System.Windows;
using DprDecoratorPattern.Pizzas;

namespace DprDecoratorPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pizza pizza;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (CheckBox1.IsChecked != null && (bool) CheckBox1.IsChecked) pizza.ExtraGarlic = true;
            if (CheckBox2.IsChecked != null && (bool) CheckBox2.IsChecked) pizza.ExtraSalami = true;
            if (CheckBox3.IsChecked != null && (bool) CheckBox3.IsChecked) pizza.ExtraRucola = true;
            if (CheckBox4.IsChecked != null && (bool) CheckBox4.IsChecked) pizza.ExtraGorgonzola = true;
            if (CheckBox5.IsChecked != null && (bool) CheckBox5.IsChecked) pizza.ExtraParmezan = true;

            try
            {
                MessageBox.Show("You ordered " + pizza.Description + " for " + pizza.Cost());
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a pizza!");
            }
           
        }

        private void ButtonBase1_OnClick(object sender, RoutedEventArgs e)
        {
            pizza = new Margerita();
        }

        private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            pizza = new Verdura();
        }

        private void ButtonBase3_OnClick(object sender, RoutedEventArgs e)
        {
            pizza = new Funghi();
        }

        private void ButtonBase4_OnClick(object sender, RoutedEventArgs e)
        {
            pizza=new Salami();
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
