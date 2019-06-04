using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatcher
{
    public partial class AddTicket : Form
    {
        public AddTicket()
        {
            InitializeComponent();
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dispatcherDataSet4.Voyage". При необходимости она может быть перемещена или удалена.
            this.voyageTableAdapter2.Fill(this.dispatcherDataSet4.Voyage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dispatcherDataSet4.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter4.Fill(this.dispatcherDataSet4.Route);
            textBox2.Text = DateTime.Now.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void routeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
