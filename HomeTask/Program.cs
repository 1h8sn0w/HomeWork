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
            CVehicle Audi = new CCar("Audi", point1, 250, 10000, 2005);
            
            CCar Bently = new CCar("Bently", point2, 450, 1000000, 2019);
            Console.WriteLine(Audi);
            Console.WriteLine(Bently);
            CPlane Boing = new CPlane(point1, "Boing", 10000, 400, 15000, 10000000, 2010);
            Console.WriteLine(Boing);
            CVehicle[] masVehicles = new CVehicle[3];
            masVehicles[0] = Audi;
            masVehicles[1] = Bently;
            masVehicles[2] = Boing;
            foreach (var item in masVehicles)
            {
                if (item.Price > 99999)
                {
                    Console.WriteLine("Прайс больше 100000");
                }
                Console.WriteLine(item);
            }
        }
    }
}
