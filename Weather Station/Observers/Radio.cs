using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    class Radio : IObserver<Forecast>
    {
        private IDisposable unsubsctriber;
        private string text;
        public void OnCompleted()
        {
            Console.WriteLine("Radio : ", text);
            Unsunscriber();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("ERROR");
        }
    
        public void OnNext(Forecast value)
        {
            Console.WriteLine("Radio : ", value);
        }
        public void Unsunscriber()
        {
            unsubsctriber.Dispose();
        }
    }

}
