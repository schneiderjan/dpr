using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Input;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Wpf;
using CategoryAxis = OxyPlot.Axes.CategoryAxis;
using LinearAxis = OxyPlot.Axes.LinearAxis;
using LineSeries = OxyPlot.Series.LineSeries;

namespace DprStrategyPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public DiskSchedulingContext Context;
       
        private readonly DiskSchedulingViewModel _diskSchedulingViewModel;
        private readonly Timer _timer;
        private int _index;

        private int _count;

        private Request _currentRequest;
        private string _currentStrategy;
        private List<int> _requestList;
        private List<Request> _requests;
        private int _size;

        public MainWindow()
        {
            InitializeComponent();
            _timer = new Timer { Interval = 1000 };
            _timer.Elapsed += TimerOnTick;

            //Creates a random list of requests.
            SetNewRandomList();

            //Set current reuest as first.
            _currentRequest = _requests[0];

            //Set Fifo by default.
            Context = new DiskSchedulingContext(new FifoScheduling(), _requests, _requests[0]);
            _currentStrategy = "Fifo strategy";

            //Initialize the plot model.
            var plotModel = CreatePlotModel(_size, _requests.Count, _requestList, -1);

            //Initilize the view model.
            _diskSchedulingViewModel =
                new DiskSchedulingViewModel
                {
                    CurrectRunningProceses = new ObservableCollection<string>(),
                    PlotSeries = new ObservableCollection<DataPoint>(),
                    RequestList = new ObservableCollection<int>(),
                    Color = "Black",
                    PlotModel = plotModel,

                    AddRequestsManuallyVisibility=Visibility = Visibility.Collapsed,

                    IsAddRandomCommandEnabled = true,
                    IsAddListCommandEnabled = true,
                    IsAddRequestsManuallyCommand = true,
                    IsCancelCommandEnabled = true,

                    IsFifoButtonEnabled = false,
                    IsSstfButtonEnabled = true,
                    IsScanButtonEnabled = true,

                    IsStartButtonEnabled = true,
                    IsStopButtonEnabled = false,
                    List="",

                    DprStrategyPatternMainWindow = this
                };
            //This fuction sets the bindings from DiskSchedulingViewModel to the UI.
            DataContext = _diskSchedulingViewModel;

            //Creates a new series list for the plot.
            _diskSchedulingViewModel.PlotModel.Series.Add
            (
                new LineSeries
                {
                    StrokeThickness = 1,
                    Color = OxyColors.Black,
                    MarkerType = MarkerType.Circle,
                    MarkerFill = OxyColors.Black,
                    ItemsSource = _diskSchedulingViewModel.PlotSeries,
                    Background = OxyColors.Transparent
                });
            
            //Updtae the UI list with new request list.
            AddToUi();
        }

        
        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            Task.Run(() =>
            {
                _index = -1;
                _currentRequest = Context.GetNextRequest();

                //List is cleared.
                if (_currentRequest == null)
                {
                    Dispatcher.Invoke(() =>
                    {
                        _timer.Stop();
                        _diskSchedulingViewModel.IsStopButtonEnabled = false;
                        _diskSchedulingViewModel.IsStartButtonEnabled = true;
                        _diskSchedulingViewModel.IsAddRequestsManuallyCommand = true;
                        _diskSchedulingViewModel.IsAddRandomCommandEnabled = true;

                    });
                    return;

                }
                //To enable updatting data to the OxyPlot plot UI the plot must be invalidated.
                _diskSchedulingViewModel.PlotModel.InvalidatePlot(false); //Display current

                for (var i = 0; i < _requestList.Count; i++)
                {
                    if (_requestList[i] == _currentRequest.Current)
                    {
                        _index = i;
                    }
                }
                for (var i = 0; i < _requests.Count; i++)
                {
                    if (_requests[i].Current != _currentRequest.Current) continue;
                    //xx = _requests.Count;
                    _requests.RemoveAt(i);
                        
                    break;
                }

                _diskSchedulingViewModel.PlotSeries.Add(new DataPoint(_index, _count));

                _count--;


                Dispatcher.Invoke(delegate
            {
                _diskSchedulingViewModel.CurrectRunningProceses.Add("Current request: " + _currentRequest.Current + "     Strategy: " + _currentStrategy);
                ListBoxOutput.ScrollIntoView(ListBoxOutput.Items[ListBoxOutput.Items.Count - 1]);
            });


                _diskSchedulingViewModel.PlotModel.InvalidatePlot(true); //Display current
            });
        }

        //Stop the timer.
        public void StopCommand()
        {
            _timer.Stop();
        }

        //Start the timer.
        public void StartCommand()
        {
            _diskSchedulingViewModel.CurrectRunningProceses.Clear();
            
            //CreateRequestList();
            GetFromUi();
            _count = _requests.Count;

            Context.Requests = _requests;
            Context.CurrentRequest = _requests[0];

            _diskSchedulingViewModel.PlotSeries.Clear();

            //Add first element.
            _currentRequest = _requests[0];

            for (var i = 0; i < _requestList.Count; i++)
            {
                if (_requestList[i] == _currentRequest.Current&& _requestList[i]!=-1)
                {
                    _index = i;
                }
            }
            for (var i = 0; i < _requests.Count; i++)
            {
                if (_requests[i].Current == _currentRequest.Current)
                {
                    _requests.RemoveAt(i);
                    break;
                }
            }
            _diskSchedulingViewModel.PlotSeries.Add(new DataPoint(_index, _count));
            _count--;
            Dispatcher.Invoke(delegate
            {
                _diskSchedulingViewModel.CurrectRunningProceses.Add("Current request: " + _currentRequest.Current + "     Strategy: " + _currentStrategy);
                ListBoxOutput.ScrollIntoView(ListBoxOutput.Items[ListBoxOutput.Items.Count - 1]);
            });

            //Start timer.
            _timer.Start();
        }

        //Change to Fifo scheduling.
        public void FifoCommand()
        {
            Context = new DiskSchedulingContext(new FifoScheduling(), _requests, _currentRequest);
            _currentStrategy = "Fifo strategy";
        }

        //Change to Fifo scheduling.
        public void SstfCommand()
        {
            Context = new DiskSchedulingContext(new SstfScheduling(), _requests, _currentRequest);
            _currentStrategy = "Sstf strategy";
        }

        //Change to Scan scheduling.
        public void ScanCommand()
        {
            Context = new DiskSchedulingContext(new ScanDiskScheduling(), _requests, _currentRequest);
            _currentStrategy = "Scan strategy";
        }

        //Create a plot model.
        private static PlotModel CreatePlotModel(int size, int height, List<int> requestList , int count)
        {
            var plotModel = new PlotModel
            {
                PlotAreaBorderColor = OxyColors.Transparent,
                Background = OxyColors.Transparent,
                PlotAreaBackground = OxyColors.Transparent
            };

            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                AbsoluteMaximum = height+1,
                AbsoluteMinimum = 0,
                Maximum = height+1,
                Minimum = 0,
                MajorTickSize = 0,
                MinorTickSize = 0,
                TextColor = OxyColors.Transparent,
                AxislineColor = OxyColors.Black
            });

            plotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Top,
                AbsoluteMaximum = size-0.5,
                AbsoluteMinimum = -1,
                Maximum = size-0.5,
                Minimum = -1,
                Title = "Requests",
                Labels =
                {
                    requestList[0].ToString(),
                    requestList[1].ToString(),
                    requestList[2].ToString(),
                    requestList[3].ToString(),
                    requestList[4].ToString(),
                    requestList[5].ToString(),
                    requestList[6].ToString(),
                    requestList[7].ToString(),
                    requestList[8].ToString(),
                    requestList[9].ToString(),
                    requestList[10].ToString(),
                     requestList[11].ToString(),
                    requestList[12].ToString(),
                    requestList[13].ToString(),
                    requestList[14].ToString(),
                    requestList[15].ToString(),
                    requestList[16].ToString(),
                    requestList[17].ToString(),
                    requestList[18].ToString(),
                    requestList[19].ToString(),
                     requestList[20].ToString(),
                     requestList[21].ToString(),
                    requestList[22].ToString(),
                    requestList[23].ToString(),
                    requestList[24].ToString(),
                    requestList[25].ToString(),
                    requestList[26].ToString(),
                    requestList[27].ToString(),
                    requestList[28].ToString(),
                    requestList[29].ToString(),
                    requestList[30].ToString(),
                    requestList[31].ToString(),
                    requestList[32].ToString(),
                    requestList[33].ToString(),
                    requestList[34].ToString(),
                    requestList[35].ToString(),
                    requestList[36].ToString(),
                    requestList[37].ToString(),
                    requestList[38].ToString(),
                    requestList[39].ToString(),
                     requestList[40].ToString(),
                    requestList[41].ToString(),
                    requestList[42].ToString(),
                    requestList[43].ToString(),
                    requestList[44].ToString(),
                    requestList[45].ToString(),
                    requestList[46].ToString(),
                    requestList[47].ToString(),
                    requestList[48].ToString(),
                    requestList[49].ToString(),
                     requestList[50].ToString(),
                    requestList[51].ToString(),
                    requestList[52].ToString(),
                    requestList[53].ToString(),
                    requestList[54].ToString(),
                    requestList[55].ToString(),
                    requestList[56].ToString(),
                    requestList[57].ToString(),
                    requestList[58].ToString(),
                    requestList[59].ToString()
                },
                MajorTickSize = 0
            });

            return plotModel;
        }

        //Get list from 
        public void SetNewManualList()
        {
            //Clear lists.
            _requests.Clear();
            _requestList.Clear();

            //Check if there're numbers in the TextBox.
            if (_diskSchedulingViewModel.NewList == null) return;
            
            //Get numbers form the TextBox.
            var stringList = _diskSchedulingViewModel.NewList.Split(' ', ',');

            //Extra list to count duplicates.
            var duplicateRequests = new List<int>();

            //Add requests based on the string list.
            foreach (var t in stringList)
            {
                if (t == "") continue;

                //Add a new request in the request list
                _requests.Add(new Request {Current = Convert.ToInt32(t), Previous = -1});
                duplicateRequests.Add(Convert.ToInt32(t));
            }

            //Remove duplicates.
            var copy2 = duplicateRequests.Distinct().ToList();
            copy2.Sort();
            duplicateRequests = copy2;
                
            //Update the  chart list.
            foreach (var t in duplicateRequests)
            {
                _requestList.Add(t);
            }
            for (var i = duplicateRequests.Count; i < 60; i++)
            {
                _requestList.Add(-1);
            }

            //Set the current context to fiven request list.
            Context.Requests = _requests;
            Context.CurrentRequest = _requests[0];

            //Clear Plot and create a new instance.
            _diskSchedulingViewModel.PlotModel = CreatePlotModel(duplicateRequests.Count, _requests.Count, _requestList, -1);
            _diskSchedulingViewModel.PlotModel.Series.Clear();
            _diskSchedulingViewModel.PlotModel.Series.Add
            (
                new LineSeries
                {
                    StrokeThickness = 1,
                    Color = OxyColors.Black,
                    MarkerType = MarkerType.Circle,
                    MarkerFill = OxyColors.Black,
                    ItemsSource = _diskSchedulingViewModel.PlotSeries,
                    Background = OxyColors.Transparent
                });

            AddToUi();

            _diskSchedulingViewModel.CurrectRunningProceses.Add(_requests.Count.ToString());
        }

        //Set a random list.
        public void SetNewRandomList()
        {
            _requests=new List<Request>();
            _requestList=new List<int>();

            _requests = GenerateReadRequests();


            foreach (var t in _requests)
            {
                _requestList.Add(t.Current);
            }

            _requestList.Sort();

            var x =_requestList.Distinct().ToList();
            _requestList = x;

            _size  = _requestList.Count;

            for (var i = _requestList.Count; i < 60; i++)
            {
                _requestList.Add(-1);
            }

            if (Context != null)
            {
                Context.Requests = _requests;
                Context.CurrentRequest = _requests[0];
            }

            if (_diskSchedulingViewModel != null)
            {
                _diskSchedulingViewModel.PlotModel = CreatePlotModel(_size, _requests.Count, _requestList, -1);
                _diskSchedulingViewModel.PlotModel.Series.Clear();
                _diskSchedulingViewModel.PlotModel.Series.Add
                (
                    new LineSeries
                    {
                        StrokeThickness = 1,
                        Color = OxyColors.Black,
                        MarkerType = MarkerType.Circle,
                        MarkerFill = OxyColors.Black,
                        ItemsSource = _diskSchedulingViewModel.PlotSeries,
                        Background = OxyColors.Transparent


                    });

                AddToUi();

                _diskSchedulingViewModel.CurrectRunningProceses.Add(_requests.Count.ToString());
            }
        }
    
        //Generate random list.
        private static List<Request> GenerateReadRequests()
        {
            var rnd = new Random();
            var generatedRequest = new List<Request>();
            generatedRequest.Add(
                new Request
                {
                    Current = rnd.Next(0, 100),
                    Previous = -1
                });

            for (int i = 0; i <= 23; i++) //25 items will be added
            {
                var randInt = rnd.Next(0, 99);
                foreach (var j in generatedRequest.ToList())
                {
                    if (j.Current == randInt)
                    {
                        do
                        {
                            randInt = rnd.Next(0, 100);
                        } while (randInt == j.Current);
                    generatedRequest.Add(new Request
                        {
                            Current = randInt,
                            Previous = -1
                        });
                        break;
                    }
                    generatedRequest.Add(new Request
                    {
                        Current = randInt,
                        Previous = -1
                    });
                    break;
                }
            }
            return generatedRequest;
        }

        //Get list from the UI list.
        private void GetFromUi()
        {
            _requests.Clear();

            var numbers = _diskSchedulingViewModel.List.Split(' ');
            for (var i = 1; i < numbers.Length; i++)
            {
                if(numbers[i]!="")
                    _requests.Add(new Request {Current = Convert.ToInt32(numbers[i]), Previous = -1});
            }
        }

        //Update the list in UI.
        private void AddToUi()
        {
            if (_diskSchedulingViewModel == null) return;

            _diskSchedulingViewModel.RequestList.Clear();
            foreach (var t in _requests)
            {
                _diskSchedulingViewModel.RequestList.Add(t.Current);
            }

            _diskSchedulingViewModel.List = "Queue:";

            foreach (var t in _requests)
            {
                _diskSchedulingViewModel.List = _diskSchedulingViewModel.List + "  " + t.Current;
            }
        }

        private void UIElement_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !OnlyNumeric(e.Text);
        }
        public static bool OnlyNumeric(string text)
        {
            Regex regex = new Regex("[^0-9.-]+"); // accepted characters from 0-9
            return !regex.IsMatch(text);
        }
    }

}


