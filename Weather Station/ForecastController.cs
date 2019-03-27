//using System;
//using System.Collections.Generic;

//namespace Weather_Station
//{
//    class ForecastController : IObservable<Forecast>
//    {
//        public List<IObserver<Forecast>> observers = new List<IObserver<Forecast>>();
//        public IDisposable Subscribe(IObserver<Forecast> observer)
//        {
//            if (!observers.Contains(observer))
//                observers.Add(observer);
//            return new Unsubscriber(observers, observer);
//        }
//        public void UnSubscribe(IObserver<Forecast> observer)
//        {
//            observers.Remove(observer);
//        }

//        class Unsubscriber : IDisposable
//        {
//            private List<IObserver<Forecast>> _observers;
//            private IObserver<Forecast> _observer;

//            public Unsubscriber(List<IObserver<Forecast>> observers, IObserver<Forecast> observer)
//            {
//                this._observers = observers;
//                this._observer = observer;
//            }

//            public void Dispose()
//            {
//                if (_observer != null && _observers.Contains(_observer))
//                    _observers.Remove(_observer);
//            }
//        }
//        public void TransmitForecast(Forecast value)
//        {
//            foreach (var observer in observers)
//            {
//                if (observers.Contains(observer))
//                {
//                    observer.OnNext(value);
//                }
//            }
//        }
//    }
//}

