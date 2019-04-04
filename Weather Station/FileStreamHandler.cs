using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    class FileStreamHandler
    {
        public static List<string> forecast = new List<string>();
        public static void Writer(ref Forecast forecast, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine(forecast);
            }
        }
        public static void Reader(string filename)
        {
            using (var reader = new StreamReader(filename))
            {
                List<string> time = new List<string>();
                List<string> day = new List<string>();
                List<string> temp = new List<string>();
                List<string> humid = new List<string>();
                List<string> preas = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    time.Add(values[0]);//.Replace("time=", "").Trim());
                    day.Add(values[1]);//.Replace("day=", "").Trim());
                    temp.Add(values[2]);//.Replace("t=", "").Trim());
                    humid.Add(values[3]);//.Replace("h=", "").Trim());
                    preas.Add(values[4]);//.Replace("p=", "").Trim());
                }
            forecast = time.Concat(day).Concat(temp).Concat(humid).Concat(preas).ToList();
            }
            
        }
    }
}
