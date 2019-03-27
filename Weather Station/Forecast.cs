using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace Weather_Station
{
    class Forecast 
    {
        public double Temp 
        {
            get
            {
                var results = Client.Query(City);
                return results.Main.Temperature.CelsiusCurrent;
            }

        }
        public double Humid
        {
            get
            {
                var results = Client.Query(City);
                return results.Main.Humdity;
            }

        }
        public double Press
        {
            get
            {
                var results = Client.Query(City);
                return results.Main.Pressure;
            }

        }
        public String City { get;  set; }
        public OpenWeatherAPI.OpenWeatherAPI Client { get; set; }

        public override string ToString()
        {
            return$"Temp is {Temp}C, Humidity is {Humid}, Pressure is {Press}";
        }
    }
}
