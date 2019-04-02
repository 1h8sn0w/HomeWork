using System;

namespace Weather_Station
{
    class Radio : IObserver<Forecast>
    {
        public delegate void ForecastHandler(string message);
        public event ForecastHandler NewForecast;
        public void OnCompleted()
        {            
        }

        public void OnError(Exception error)
        { 
        }
    
        public void OnNext(Forecast value)
        {
            if (NewForecast != null)
            {
               Console.WriteLine("Event called ! ! !");
            }
            Console.WriteLine("Radio :temp {0}C, press {1}, humid {2} ", value.Temp, value.Press, value.Humid);
        }
    }

}
