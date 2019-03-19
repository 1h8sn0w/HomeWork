using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class CBatmobile : CVehicle, IFly, IMove, ISwim
    {
        public CBatmobile(string shoot, bool exist): base (500, 4620000, 2013)
        {
            Shoot = shoot;
            Exist = exist;
        }

        public string Shoot { get; }
        public bool Exist { get; }

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
