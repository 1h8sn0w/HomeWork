using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ForecastController provider = new ForecastController();
            Radio radio = new Radio();
            Console.WriteLine(provider);
            Console.WriteLine(radio);
        }
    }
}
