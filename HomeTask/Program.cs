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
            CVehicle Audi = new CCar("Audi", point1, 210, 3000, 2004); //Car
            CCar Bently = new CCar("Bently", point2, 450, 1000000, 2019); //Car
            CCar Renault = new CCar("Renault", point2, 250, 10000, 2015);
            CCar Shevrolet = new CCar("Shevrolet", point2, 180, 1500, 2003);
            CCar Opel = new CCar("Open", point2, 150, 2000, 2001);
            //Console.WriteLine(Audi);
            //Console.WriteLine(Bently);
            CPlane Boing = new CPlane(point1, "Boing", 10000, 400, 15000, 10000000, 2010); //Plane
            CPlane Mig = new CPlane(point1, "Mig", 4, 400, 15000, 10000000, 2009);
            CPlane Ill = new CPlane(point1, "Ill", 10000, 400, 15000, 10000000, 2005);
            CPlane Thunderbird = new CPlane(point1, "Thunderbird", 10000, 400, 15000, 10000000, 2001);
            CShip Cezar = new CShip(point2, "Cezar", 192168, 10000, 200, 2147483647, 2014); //Ship
            CShip USA = new CShip(point2, "USA", 193528, 10000, 140, 2047483647, 209);
            CShip Crab = new CShip(point2, "Cab", 123448, 10000, 300, 2147483047, 2003);
            CShip Lotus = new CShip(point2, "Lotus", 876230, 10000, 100, 107483647, 2001);
            //Console.WriteLine(Boing);
            CVehicle[] masVehicles = new CVehicle[13];
            masVehicles[0] = Audi;
            masVehicles[2] = Bently;
            masVehicles[1] = Renault;
            masVehicles[3] = Shevrolet;
            masVehicles[4] = Opel;
            masVehicles[5] = Boing;
            masVehicles[6] = Ill;
            masVehicles[7] = Mig;
            masVehicles[8] = Thunderbird;
            masVehicles[9] = Cezar;
            masVehicles[10] = USA;
            masVehicles[11] = Crab;
            masVehicles[12] = Lotus;

            int intinput = 0;
            do
            {
                Console.WriteLine("Type what you want:\n 1-Price sort (expensive first)\n 2-Year 2000 - 2005, speed > 150, cheap first\n 3-Cars older then 5 years\n 4-Get Ships older then 5 years, expensive first\n 5-Exit");
                string input = Console.ReadLine();
                intinput = Convert.ToInt32(input);
                switch (intinput)
                {
                    case 1:
                        {
                            // 1-Price sort (expensive first)
                            Array.Sort(masVehicles, new PriceHighCompare());
                            foreach (var item in masVehicles)
                            {
                                Console.Write(item + ", ");
                                Console.WriteLine(item.Price + "$");
                            }
                            break;
                        }
                    case 2:
                        {
                            //Year 2000 - 2005, speed > 150, cheap first
                            foreach (var item in masVehicles)
                            {
                                Array.Sort(masVehicles, new PriceLowCompare());
                                if (item.DataOfMan > 2000)
                                {
                                    if (item.DataOfMan < 2005)
                                    {
                                        if (item.Speed > 150)
                                        {
                                            Console.Write(item + ", ");
                                            Console.Write(item.DataOfMan + "year ");
                                            Console.Write(item.Speed + "km/h ");
                                            Console.WriteLine(item.Price + "$ ");
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            //Cars older then 5 years

                            break;
                        }
                    case 4:
                        {
                            //Get Ships older then 5 years, expensive first

                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(1);
                            break;
                        }
                    default:
                        break;
                }
            } while (intinput != 5);
        }
    }
}
