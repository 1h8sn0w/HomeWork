using System;

namespace Weather_Station
{
    class Mobile : IObserver<Forecast>
    {
        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Forecast value)
        {
            Console.WriteLine("Mobile :temp {0}C, press {1}, humid {2} ", value.Temp, value.Press, value.Humid);
        }
    }
}
