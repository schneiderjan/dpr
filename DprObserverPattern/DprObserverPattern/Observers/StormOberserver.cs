using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DprObserverPattern.Observers
{
    public class StormOberserver : IPushObserver, INotifyPropertyChanged
    {
        private StormSubject stormSubject;
        private StormData _stormData;
        public StormData StormDataUi
        {
            get { return _stormData; }
            set { _stormData = value; OnPropertyChanged(); }
        }

        public StormOberserver(StormSubject subject)
        {
            stormSubject = subject;
            stormSubject.Attach(this);
        }
        public void Update(StormData stormData)
        {
            _stormData = stormData;
        }

        //OnPropertyChanged Event
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
