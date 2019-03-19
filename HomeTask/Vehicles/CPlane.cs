using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class CPlane : CVehicle, IFly
    {
        public CPlane(Gps gps, string plane, int pass, int hight, int speed, int price, int dataOfMan) : base(speed, price, dataOfMan)
        {
            Plane = plane;
            Pass = pass;
            Hight = hight;
        }
        public void Fly()
        {
            Console.WriteLine("I can Fly");
        }

        public string Plane { get; set; }
        public int Pass { get; set; }
        public int Hight { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()},{Plane}";
        }
    }
}
