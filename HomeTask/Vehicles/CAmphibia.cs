using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class CAmphibia : CVehicle, IFly, IMove, ISwim
    {
        public CAmphibia(int speed, int price, int dataofMan, string color) : base (speed, price, dataofMan)
        {
            Color = color;
        }

        public string Color { get; set; }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
