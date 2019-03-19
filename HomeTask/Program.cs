using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Gps point1 = new Gps(50.1324, 51.12412);
            Gps point2 = new Gps(43.1212, 54.12412);
            CVehicle Audi = new CCar("Audi", point1, 250, 10000, 2005); //Car
            CCar Bently = new CCar("Bently", point2, 450, 1000000, 2019); //Car
            //Console.WriteLine(Audi);
            //Console.WriteLine(Bently);
            CPlane Boing = new CPlane(point1, "Boing", 10000, 400, 15000, 10000000, 2010); //Plane
            CShip Cezar = new CShip(point2, "Cezar", 192168, 10000, 200, 2147483647, 2014); //Ship
            //Console.WriteLine(Boing);
            CVehicle[] masVehicles = new CVehicle[4];
            masVehicles[0] = Audi;
            masVehicles[2] = Boing;
            masVehicles[1] = Bently;
            masVehicles[3] = Cezar;
            int intinput = 0;
            do
            {
                Console.WriteLine("Type what you want: 1-Year 2019, 2-price 100K+, 3-speed is less then 500km/h, 4-Exit");
                string input = Console.ReadLine();
                intinput = Convert.ToInt32(input);
                switch (intinput)
                {
                    case 1:
                        {
                            foreach (var item in masVehicles)
                            {
                                if (item.DataOfMan == 2019)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine(Convert.ToString(item) + " Year 2019");
                                    Console.WriteLine(item.DataOfMan);
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            foreach (var item in masVehicles)
                            {
                                if (item.Price >= 100000)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine(Convert.ToString(item) + " Prise is 100k+");
                                    Console.WriteLine(item.Price);
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (var item in masVehicles)
                            {
                                if (item.Speed <= 500)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine(Convert.ToString(item) + " Speed is <500");
                                    Console.WriteLine(item.Speed);
                                }
                            }
                            break;

                        }
                    case 4:
                        {
                            Environment.Exit(1);
                            break;
                        }
                    default:
                        break;
                }
            } while (intinput != 4);  
        }
    }
}
