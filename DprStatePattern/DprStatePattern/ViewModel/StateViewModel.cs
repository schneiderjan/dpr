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
            _initializeCommand = new DelegateCommand(Initialize);
            _emergencyStopCommand = new DelegateCommand(EmergencyStop);
            SetTxtState(" - ");

            _dispatcherTimer.Tick += dispatcherTimer_Tick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            _prodChain.Pull();
            var state = _prodChain.GetState();
            SetControls(state);
            SetTxtState(state.Action);
        }

        private void SetControls(State state)
        {
            if (state is Initialized) {
               
            }
            else if (state is PreManufacturing) {
                _mainWindow.imgManufacturing.Opacity = 0.5;
                _mainWindow.imgPreManufacturing.Opacity = 0.5;
                _mainWindow.imgPostManufacturing.Opacity = 0.5;
            }
            else if (state is Manufacturing) {
                _mainWindow.imgManufacturing.Opacity = 0.5;
                _mainWindow.imgPreManufacturing.Opacity = 0.5;
                _mainWindow.imgPostManufacturing.Opacity = 0.5;
            }
            else if (state is PostManufacturing) {
                _mainWindow.imgManufacturing.Opacity = 0.5;
                _mainWindow.imgPreManufacturing.Opacity = 0.5;
                _mainWindow.imgPostManufacturing.Opacity = 0.5;
            }
            else if (state is Terminated) {
                _dispatcherTimer.Stop();
                _mainWindow.imgManufacturing.Opacity = 0.5;
                _mainWindow.imgPreManufacturing.Opacity = 0.5;
                _mainWindow.imgPostManufacturing.Opacity = 0.5;
            }

        }

        private void EmergencyStop(object obj)
        {
            _prodChain = new ProductionChain();
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

            _prodChain = new ProductionChain();
            _dispatcherTimer.Start();
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
