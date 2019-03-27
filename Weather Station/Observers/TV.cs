using System;

namespace Weather_Station
{
    class TV :IObserver<Forecast>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Radio : transmittion ended");
           // Unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {

        }

        public void OnNext(Forecast value)
        {
            Console.WriteLine("TV :temp {0}, press {1}, humid {2} ", value.Temp, value.Press, value.Humid);
        }
    }
}
