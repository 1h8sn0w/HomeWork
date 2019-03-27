using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Weather_Station
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;

            do
            {
                var client = new OpenWeatherAPI.OpenWeatherAPI("51273fea55741d0e5dc348f04d52ff5a");
                //Console.WriteLine("Press any NUMBER KEY or 0 to exit");
                //var imp = Console.ReadLine();
                //Console.WriteLine();
                //start = Convert.ToInt32(imp);
                switch (start)
                {
                    default:
                        {
                            Console.WriteLine("Enter city to get weather data for:");
                            string city = Console.ReadLine();
                            Console.WriteLine();

                            var results = client.Query(city);
                            Forecast forecast = new Forecast { City = city, Client = client };      //creating forecast

                            Radio radio = new Radio();                                              //radio online
                            TV tv = new TV();                                                       //tv online
                            Mobile mobile = new Mobile();                                           //mobile online

                            ForecastController forecastKyiv = new ForecastController();             //new Observer Controller 
                            ForecastController forecastLviv = new ForecastController();

                            //Action<Forecast> actionLviv = radio.OnNext;
                            //actionLviv += tv.OnNext;
                            //actionLviv += mobile.OnNext;

                            forecastKyiv.Subscribe(radio);                                          //new kyiv sub
                            forecastKyiv.Subscribe(tv);
                            forecastKyiv.Subscribe(mobile);
                            forecastLviv.Subscribe(radio);                                          //new kyiv sub
                            forecastLviv.Subscribe(tv);
                            forecastLviv.Subscribe(mobile);

                            radio.OnNext(forecast);
                          
                        }
                        break;
                    case 0:
                        {
                            Environment.Exit(1);
                            break;
                        }
                }

            } while (start != 0);
        }
    }
}
