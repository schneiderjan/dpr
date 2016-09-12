using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DprObserverPattern
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
