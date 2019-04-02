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
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(3600000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
            {
                var client = new OpenWeatherAPI.OpenWeatherAPI("51273fea55741d0e5dc348f04d52ff5a");
                //Console.WriteLine("Press any NUMBER KEY or 0 to exit");
                //var imp = Console.ReadLine();
                //Console.WriteLine();
                //start = Convert.ToInt32(imp);

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

                radio.NewForecast += Show_event;                                        //Event call

                Console.WriteLine(new string('-', 50));

                Action<Forecast> actionForecast = tv.OnNext;
                actionForecast += radio.OnNext;
                actionForecast += mobile.OnNext;
                actionForecast(forecast);
                Console.WriteLine(new string('-', 50));
                actionForecast -= radio.OnNext;                                             //unsub forn radio
                actionForecast(forecast);
                Console.WriteLine(new string('-', 50));

                FileStreamHandler.Writer(ref forecast, @"d:\forecast.txt");
                FileStreamHandler.Reader(@"d:\forecast.txt");
            }

        private static void Show_event(string message)
            {
                Console.WriteLine(message);
            }
        
    }
}