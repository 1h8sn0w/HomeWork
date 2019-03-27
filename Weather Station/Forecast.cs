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
        public string City { get;  set; }
        public OpenWeatherAPI.OpenWeatherAPI Client { get; set; }

        public override string ToString()
        {
            return$"Temp is {Temp}C, Humidity is {Humid}, Pressure is {Press}";
        }
    }
}
