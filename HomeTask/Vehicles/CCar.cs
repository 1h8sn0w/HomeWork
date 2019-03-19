using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class CCar : CVehicle, IMove
    {
        public CCar(string car, Gps gps, int speed, int price, int dataOfMan) : base(speed, price, dataOfMan)
        {
            Car = car;
        }
        public void Move ()
            {
            Console.WriteLine("I can Move");
            }

        public string Car { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()},{Car}";
        }
    }
}
