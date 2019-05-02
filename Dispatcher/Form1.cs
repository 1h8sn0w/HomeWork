using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            AddTicket form = new AddTicket();
            DialogResult result = form.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            ticketTableAdapter.Insert(Convert.ToInt32(form.seatN.Text), Convert.ToDecimal(form.price.Text),
                DateTime.Now, form.clientName.Text, form.passportId.Text, form.sale.ToString());
            ticketTableAdapter.Fill(this.dispatcherDataSet.Ticket);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dispatcherDataSet1.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter1.Fill(this.dispatcherDataSet1.Ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dispatcherDataSet1.Dispatcher". При необходимости она может быть перемещена или удалена.
            this.dispatcherTableAdapter1.Fill(this.dispatcherDataSet1.Dispatcher);

        }
    }
}
