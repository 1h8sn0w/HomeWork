using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    class Forecast
    {
        public Forecast(double temp, double humid, double press)
        {
            Temp = temp;
            Humid = humid;
            Press = press;
        }

        public double Temp { get; set; }
        public double Humid { get; set; }
        public double Press { get; set; }

        public override string ToString()
        {
            return$"{Temp},{Humid},{Press}";
        }
    }
}
