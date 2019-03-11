using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class CShip : CVehicle
    {
        public CShip(Gps gps, string ship, int port, int pass, int speed, int price, int dateOfMan) : base(speed, price, dateOfMan)
        {
            Ship = ship;
            Pass = pass;
            Port = Port;
        }

        public string Ship { get; set; }
        public int Pass { get; set; }
        public int Port { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()},{Ship}";
        }
    }
}
