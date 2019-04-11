using System;
using System.Timers;

namespace Weather_Station
{
    internal class Program
    {
        private static Timer _aTimer;

        private static void Main(string[] args)
        {
            SetTimer();

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            _aTimer.Stop();
            _aTimer.Dispose();

            Console.WriteLine("Terminating the application...");
        }

        private static void SetTimer()
        {
            _aTimer = new Timer(2000);
            _aTimer.Elapsed += OnTimedEvent;
            _aTimer.AutoReset = false;
            _aTimer.Enabled = true;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            var client = new OpenWeatherAPI.OpenWeatherAPI("51273fea55741d0e5dc348f04d52ff5a");

            Console.WriteLine();
            Console.WriteLine("Enter city to get weather data for:");
            //string city = Console.ReadLine();
            var city = "Kyiv";
            Console.WriteLine(city);
            Console.WriteLine();
            var results = client.Query(city);
            var forecast = new Forecast {City = city, Client = client}; //creating forecast

            var radio = new Radio(); //radio online
            var tv = new TV(); //tv online
            var mobile = new Mobile(); //mobile online

            Console.WriteLine(new string('-', 50));

            Action<Forecast> actionForecast = tv.OnNext;
            actionForecast += radio.OnNext;
            actionForecast += mobile.OnNext;
            actionForecast(forecast);
            Console.WriteLine(new string('-', 50));
            actionForecast -= radio.OnNext; //unsub forn radio
            actionForecast(forecast);
            Console.WriteLine(new string('-', 50));
            //WeatherList forecastlist = new WeatherList();
            //FileStreamHandler.Writer(ref forecast, @"d:\forecast_test.txt");
            FileStreamHandler.Reader(@"d:\forecast_test.csv");
            Console.WriteLine(new string('-', 50));
            var wl = new WeatherList(50);
            foreach (var item in FileStreamHandler.forecast) wl.Push(item);
            wl.Print();
            var temp = new WeatherList(50);
            var humid = new WeatherList(50);
            while (!wl.IsEmpty())
                if (wl.Peek().Equals("t"))
                    Console.WriteLine("+");
                else
                    humid.Push(wl.Pop());
            Console.WriteLine(new string('-', 50));
            temp.Print();
        }
    }
}