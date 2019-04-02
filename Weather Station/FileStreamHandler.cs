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
        public static void Writer(ref Forecast forecast, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine(forecast);
            }
        }
        public static void Reader(string failname)
        {
            using (StreamReader sr = new StreamReader(failname))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
