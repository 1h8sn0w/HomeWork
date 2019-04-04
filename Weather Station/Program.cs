using System;
using System.Timers;

namespace Weather_Station
{
    class Program
    {
        private static System.Timers.Timer aTimer;
        static void Main(string[] args)
        {
            SetTimer();

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();

            Console.WriteLine("Terminating the application...");
        }

        private static void SetTimer()
        {
            aTimer = new Timer(2000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            var client = new OpenWeatherAPI.OpenWeatherAPI("51273fea55741d0e5dc348f04d52ff5a");

            Console.WriteLine();
            Console.WriteLine("Enter city to get weather data for:");
            //string city = Console.ReadLine();
            string city = "Kyiv";
            Console.WriteLine(city);
            Console.WriteLine();
            var results = client.Query(city);
            Forecast forecast = new Forecast { City = city, Client = client };      //creating forecast

            Radio radio = new Radio();                                              //radio online
            TV tv = new TV();                                                       //tv online
            Mobile mobile = new Mobile();                                           //mobile online

            Console.WriteLine(new string('-', 50));

            Action<Forecast> actionForecast = tv.OnNext;
            actionForecast += radio.OnNext;
            actionForecast += mobile.OnNext;
            actionForecast(forecast);
            Console.WriteLine(new string('-', 50));
            actionForecast -= radio.OnNext;                                             //unsub forn radio
            actionForecast(forecast);
            Console.WriteLine(new string('-', 50));
            //WeatherList forecastlist = new WeatherList();
            //FileStreamHandler.Writer(ref forecast, @"d:\forecast_test.txt");
            FileStreamHandler.Reader(@"d:\forecast_test.csv");
            Console.WriteLine(new string('-', 50));
            WeatherList wl = new WeatherList(50);
            foreach (var item in FileStreamHandler.forecast)
            {
                wl.Push(item);
            }
            wl.Print();
            //WeatherList temp = new WeatherList(50);
            //WeatherList humid = new WeatherList(50);
            //while (!wl.IsEmpty())
            //{
            //    if (wl.Peek().Equals("t"))
            //    {
            //        temp.Push(wl.Pop());
            //    }
            //    else humid.Push(wl.Pop());
            //}
            Console.WriteLine(new string('-', 50));
            //temp.Print();
        }
    }
}