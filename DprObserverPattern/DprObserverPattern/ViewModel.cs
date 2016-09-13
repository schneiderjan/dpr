using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyTools.Wpf;

namespace DprObserverPattern
{
    class ViewModel: INotifyPropertyChanged
    {
        MainWindow ObserverMainWindow { get; set; }

        public ViewModel()
        {
            Search=new DelegateCommand(_doSearch);
        }

        public ICommand Search { get; private set; }

        private void _doSearch()
        {

        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; OnPropertyChanged(); }
        }

        //private string _temperature;
        //public string Temperature
        //{
        //    get { return _temperature; }
        //    set { _temperature = value; OnPropertyChanged(); }
        //}


        //OnPropertyChanged Event
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
