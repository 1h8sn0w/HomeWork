using System;

namespace Weather_Station
{
    class TV :IObserver<Forecast>
    {
        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Forecast value)
        {
            Console.WriteLine("TV :temp {0}C, press {1}, humid {2} ", value.Temp, value.Press, value.Humid);
        }
    }
}
