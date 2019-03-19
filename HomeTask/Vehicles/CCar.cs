using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class CCar : CVehicle
    {
        public CCar(string car, Gps gps, int speed, int price, int dataOfMan) : base(speed, price, dataOfMan)
        {
            Car = car;
        }

        public string Car { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()},{Car}";
        }
    }
}
