using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class PriceHighCompare : IComparer<CVehicle>
    {
        public int Compare(CVehicle x, CVehicle y)
        {
            return y.Price.CompareTo(x.Price);
        }
    }
    class PriceLowCompare : IComparer<CVehicle>
    {
        public int Compare(CVehicle y, CVehicle x)
        {
            return y.Price.CompareTo(x.Price);
        }
    }
    class YearCompare : IComparer<CVehicle>
    {
        public int Compare(CVehicle x, CVehicle y)
        {
            return y.DataOfMan.CompareTo(x.DataOfMan);
        }
    }
    class SpeedCompare : IComparer<CVehicle>
    {
        public int Compare(CVehicle x, CVehicle y)
        {
            return y.Speed.CompareTo(x.Speed);
        }

    }

}
