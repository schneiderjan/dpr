using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using DprStrategyPattern.Properties;
using OxyPlot;
using PropertyTools.Wpf;

namespace DprStrategyPattern
{
    public class DiskSchedulingViewModel:INotifyPropertyChanged
    {
        public MainWindow DprStrategyPatternMainWindow { get; set; }
        
        public DiskSchedulingViewModel()
        {
            RunCommand = new DelegateCommand(DoRunCommand);
            StopCommand = new DelegateCommand(DoStopCommand);
            FifoCommand = new DelegateCommand(DoFifoCommand);
            SstfCommand = new DelegateCommand(DoSstfCommand);
            ScanCommand = new DelegateCommand(DoScanCommand);
            AddRequestsManuallyCommand=new DelegateCommand(DoAddRequestsManuallyCommand);
            AddListCommand=new DelegateCommand(DoAddListCommand);
            CancelCommand=new DelegateCommand(DoCancelCommand);
            AddRandomCommand = new DelegateCommand(DoAddRandomCommand);
            ExportPngCommand=new DelegateCommand(DoExportPngCommand);
        }

        public ICommand RunCommand { get; private set; }
        public ICommand StopCommand { get; private set; }
        public ICommand FifoCommand { get; private set; }
        public ICommand SstfCommand { get; private set; }
        public ICommand ScanCommand { get; private set; }
        public ICommand AddRandomCommand { get; private set; }

        public ICommand AddRequestsManuallyCommand { get; private set; }
        public ICommand AddListCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }

        public ICommand ExportPngCommand { get; private set; }

        private Visibility _addRequestsManuallyVisibility;

        public Visibility AddRequestsManuallyVisibility
        {
            get { return _addRequestsManuallyVisibility; }
            set
            {
                _addRequestsManuallyVisibility = value;
                OnPropertyChanged();
            }
        }

        private string _list;
        public string List
        {
            get { return _list; }
            set { _list = value; OnPropertyChanged(); }
        }

        private string _newList;
        public string NewList
        {
            get { return _newList; }
            set { _newList = value; OnPropertyChanged(); }
        }

        private void DoAddRandomCommand()
        {
            DprStrategyPatternMainWindow.SetNewRandomList();
        }
        
        private void DoRunCommand()
        {
            DprStrategyPatternMainWindow.StartCommand();
            IsStartButtonEnabled = false;
            IsStopButtonEnabled = true;
            IsAddRequestsManuallyCommand = false;
            IsAddRandomCommandEnabled = false;
        }

        private void DoStopCommand()
        {
            DprStrategyPatternMainWindow.StopCommand();
            IsStartButtonEnabled = true;
            IsStopButtonEnabled = false;
            IsAddRequestsManuallyCommand = true;
            IsAddRandomCommandEnabled = true;
        }

        private void DoExportPngCommand()
        {
            //DprStrategyPatternMainWindow.Export();
        }

    private void DoFifoCommand()
        {
            DprStrategyPatternMainWindow.FifoCommand();
            IsFifoButtonEnabled = false;
            IsSstfButtonEnabled = true;
            IsScanButtonEnabled = true;
        }

        private void DoSstfCommand()
        {
            DprStrategyPatternMainWindow.SstfCommand();
            IsFifoButtonEnabled = true;
            IsSstfButtonEnabled = false;
            IsScanButtonEnabled = true;
        }

        private void DoScanCommand()
        {
            DprStrategyPatternMainWindow.ScanCommand();
            IsFifoButtonEnabled = true;
            IsSstfButtonEnabled = true;
            IsScanButtonEnabled = false;
        }

        public void DoCancelCommand()
        {
            AddRequestsManuallyVisibility=Visibility.Collapsed;
            IsStartButtonEnabled = true;
            IsAddRequestsManuallyCommand = true;
            IsAddRandomCommandEnabled = true;
        }

        public void DoAddListCommand()
        {
            if (NewList == null)
            {
                MessageBox.Show("Add a list of requests.");
            }
            else
            {
                DprStrategyPatternMainWindow.SetNewManualList();
                IsStartButtonEnabled = true;
                IsAddRequestsManuallyCommand = true;
                IsAddRandomCommandEnabled = true;
                AddRequestsManuallyVisibility = Visibility.Collapsed;
            }
        }

        public void DoAddRequestsManuallyCommand()
        {
            AddRequestsManuallyVisibility=Visibility.Visible;
            IsStartButtonEnabled = false;
            IsStopButtonEnabled = false;
            IsAddRequestsManuallyCommand = false;
            IsAddRandomCommandEnabled = false;
        }

        private bool _isAddRequestsManuallyCommand;
        public bool IsAddRequestsManuallyCommand
        {
            get { return _isAddRequestsManuallyCommand; }
            set { _isAddRequestsManuallyCommand = value; OnPropertyChanged(); }
        }

        private bool _isAddRandomCommandEnabled;
        public bool IsAddRandomCommandEnabled
        {
            get { return _isAddRandomCommandEnabled; }
            set { _isAddRandomCommandEnabled = value; OnPropertyChanged(); }
        }

        private bool _isAddListCommandEnabled;
        public bool IsAddListCommandEnabled
        {
            get { return _isAddListCommandEnabled; }
            set { _isAddListCommandEnabled = value; OnPropertyChanged(); }
        }

        private bool _isCancelCommandEnabled;
        public bool IsCancelCommandEnabled
        {
            get { return _isCancelCommandEnabled; }
            set { _isCancelCommandEnabled = value; OnPropertyChanged(); }
        }
        
        private bool _isStartButtonEnabled;
        public bool IsStartButtonEnabled
        {
            get { return _isStartButtonEnabled; }
            set { _isStartButtonEnabled = value; OnPropertyChanged(); }
        }

        private bool _isStopButtonEnabled;
        public bool IsStopButtonEnabled
        {
            get { return _isStopButtonEnabled; }
            set { _isStopButtonEnabled = value; OnPropertyChanged(); }
        }

        private bool _isScanButtonEnabled;
        public bool IsScanButtonEnabled
        {
            get { return _isScanButtonEnabled; }
            set { _isScanButtonEnabled = value; OnPropertyChanged(); }
        }

        private bool _isFifoButtonEnabled;
        public bool IsFifoButtonEnabled
        {
            get { return _isFifoButtonEnabled; }
            set { _isFifoButtonEnabled = value; OnPropertyChanged(); }
        }

        private bool _isSstfButtonEnabled;
        public bool IsSstfButtonEnabled
        {
            get { return _isSstfButtonEnabled; }
            set { _isSstfButtonEnabled = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Binds the instace of the chart OxyPlot.
        /// </summary>
        private PlotModel _plotModel;
        public PlotModel PlotModel {
            get { return _plotModel; }
            set { _plotModel = value; OnPropertyChanged(); }
        }

        public ObservableCollection<DataPoint> PlotSeries;

        //ObservableCollection of int to keep track of oxyplot labels
        public ObservableCollection<int> RequestList { get; set; }

        private string _color;
        public string Color
        {
            get { return _color; }
            set { _color = value; OnPropertyChanged(); }
        }

        //ObservableCollection of string with the runningRequest; used for oxyplot
        public ObservableCollection<string> CurrectRunningProceses { get; set; }
        
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
