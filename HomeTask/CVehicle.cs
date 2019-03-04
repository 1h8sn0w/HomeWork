using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    abstract class CVehicle
    {

        protected CVehicle(int speed, int price, int dataOfMan)
        {
            Speed = speed;
            Price = price;
            DataOfMan = dataOfMan;
        }

        public static int Speed { get; set; }
        public static int Price { get; set; }
        public static int DataOfMan { get; set; }
    }
}
