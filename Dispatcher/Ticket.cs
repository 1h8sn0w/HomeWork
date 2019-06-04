using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatcher
{
    class Ticket
    {
        public int Id { get; set; }
        public int SeatN { get; set; }
        public float Cost { get; set; }
        public string ClientName { get; set; }
        public string Passport { get; set; }
        public byte Privileges { get; set; }
    }
}
