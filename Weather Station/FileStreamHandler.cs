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
        public static void Reader(string filename)
        {
            //using (StreamReader sr = new StreamReader(filename))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }

            //}
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    //int type = int.Parse(sr.ReadLine());
                    string strparams = sr.ReadLine();
                    string[] p = strparams.Split('=');
                    if (p[0] == "t")
                    {
                        Console.WriteLine("t");
                    }
                    if (p[0] == "h")
                    {
                        Console.WriteLine("h");
                    }
                    if (p[0] == "p")
                    {
                        Console.WriteLine("p");
                    }
                }
            }
        }
    }
}
