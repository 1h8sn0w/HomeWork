using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    class ForecastController : IObservable<Forecast>
    {
        public List<IObserver<Forecast>> observers = new List<IObserver<Forecast>>();
        public IDisposable Subscribe(IObserver<Forecast> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }


        class Unsubscriber : IDisposable
        {
            private List<IObserver<Forecast>> observers;
            private IObserver<Forecast> observer;

            public Unsubscriber(List<IObserver<Forecast>> observers, IObserver<Forecast> observer)
            {
                this.observers = observers;
                this.observer = observer;
                //observers.Remove(observer);
            }

            public void Dispose()
            {
                if (observer != null && observers.Contains(observer))
                    observers.Remove(observer);
            }
        }
        public void TransmitForecast(Forecast value)
        {
            foreach (var observer in observers)
            {
                if (observers.Contains(observer))
                {
                    observer.OnNext(value);
                }
            }
        }
    }
}

