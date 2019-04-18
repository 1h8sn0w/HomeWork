using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Station_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            var connection = ConnectionToBd.GetConnection();
            button1.Enabled = false;
        }

        private void buttonKyiv_Click(object sender, EventArgs e)
        {
            var connection = ConnectionToBd.GetConnection();

            var commandSql = new SqlCommand(@"SELECT Name, Temperature, Precipitations, TypeOfCityzens, Date FROM Region JOIN Weather ON Region.Name = Weather.Region WHERE Region.Name = 'Kyiv'", connection);

            SqlDataReader reader = commandSql.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                label1.Text += reader.GetName(i) + new string(' ', 20);
            }
            label1.Text += "\n";


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                            label1.Text += reader[i] + new string(' ', 20);
                    }

                    label1.Text += "\n";
                }
            }

        }

        private void buttonLviv_Click(object sender, EventArgs e)
        {
            CommandSQL command = new CommandSQL();
            command.ReaderSql(@"SELECT Name, Temperature, Precipitations, TypeOfCityzens, Date FROM Region JOIN Weather ON Region.Name = Weather.Region WHERE Region.Name = 'Lviv'");
        }

        private void buttonBerlin_Click(object sender, EventArgs e)
        {

            var connection = ConnectionToBd.GetConnection();

            var commandSql = new SqlCommand(@"SELECT Name, Temperature, Precipitations, Date FROM Region JOIN Weather ON Region.Name = Weather.Region WHERE Region.Name = 'Berlin'", connection);

            SqlDataReader reader = commandSql.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                label1.Text += reader.GetName(i) + new string(' ', 20);
            }
            label1.Text += "\n";


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        label1.Text += reader[i] + new string(' ', 20);
                    }

                    label1.Text += "\n";
                }
            }
        }

        private void buttonSelo_Click(object sender, EventArgs e)
        {

            var connection = ConnectionToBd.GetConnection();

            var commandSql = new SqlCommand(@"SELECT Name, Temperature, Precipitations, Date FROM Region JOIN Weather ON Region.Name = Weather.Region WHERE Region.Name = 'Selo'", connection);

            SqlDataReader reader = commandSql.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                label1.Text += reader.GetName(i) + new string(' ', 20);
            }
            label1.Text += "\n";


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        label1.Text += reader[i] + new string(' ', 20);
                    }

                    label1.Text += "\n";
                }
            }
        }
    }
}
