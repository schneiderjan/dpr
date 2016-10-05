using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace DprStatePattern
{
    public class StateViewModel : INotifyPropertyChanged
    {
        private MainWindow _mainWindow;
        private ProductionChain _prodChain;
        private DispatcherTimer _dispatcherTimer = new DispatcherTimer();


        public StateViewModel(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            _prodChain = new ProductionChain();
            _initializeCommand = new DelegateCommand(Initialize);
            _emergencyStopCommand = new DelegateCommand(EmergencyStop);
            SetTxtState("Terminated");

            _dispatcherTimer.Tick += dispatcherTimer_Tick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            _prodChain.Pull();
            SetTxtState(_prodChain.GetStateAction());
        }

        private void EmergencyStop(object obj)
        {

        }

        private void SetTxtState(string v)
        {
            _mainWindow.txtState.Text = v;
        }

        private ICommand _initializeCommand;
        public ICommand InitializeCommand
        {
            get { return _initializeCommand; }
            set { _initializeCommand = value; }
        }

        private ICommand _emergencyStopCommand;
        public ICommand EmergencyStopCommand
        {
            get { return _emergencyStopCommand; }
            set { _emergencyStopCommand = value; }
        }

        private void Initialize(object obj)
        {
            _mainWindow.btnInit.IsEnabled = false;
            _mainWindow.btnEmergencyStop.IsEnabled = true;

            _dispatcherTimer.Start();

            _prodChain.Pull();
            SetTxtState("Initializing ");
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
