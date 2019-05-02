using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Dispatcher
{
    class TicketCreate : DbContext
    {
        public TicketCreate() : base("Dispatcher.Properties.Settings.DispatcherConnectionString")
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
