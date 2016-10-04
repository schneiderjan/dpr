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

namespace DprIteratorPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ChannelRepository channelRepository;
        IIterator iterator;
        public MainWindow()
        {
            InitializeComponent();
            channelRepository = new ChannelRepository();
            iterator = channelRepository.GetIterator();
            btnChUp.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }

        private void btnChDown_Click(object sender, RoutedEventArgs e)
        {
            var channel = (Channel)iterator.Previous();
            if (channel == null) return;
            txtChannel.Text = channel.Name;
        }

        private void btnChUp_Click(object sender, RoutedEventArgs e)
        {
            var channel = (Channel)iterator.Next();
            if (channel == null) return;
            txtChannel.Text = channel.Name;
        }
    }
}
