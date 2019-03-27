using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    class Radio : IObserver<Forecast>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Radio : transmittion ended");            
        }

        public void OnError(Exception error)
        { 

        }
    
        public void OnNext(Forecast value)
        {
            Console.WriteLine("Radio :temp {0}, press {1}, humid {2} ", value.Temp, value.Press, value.Humid);
        }
    }

}
