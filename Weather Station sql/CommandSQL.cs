using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station_sql
{
    class CommandSQL
    {
        Form1 form = new Form1();
        public void ExecuteQueries(string command)
        {
            var connection = ConnectionToBd.GetConnection();
            SqlCommand cmd = new SqlCommand(command,connection);
            cmd.ExecuteNonQuery();
        }

        public void ReaderSql(string command)
        {

            var connection = ConnectionToBd.GetConnection();

            var commandSql = new SqlCommand(command, connection);

            SqlDataReader reader = commandSql.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                form.label1.Text += reader.GetName(i) + new string(' ', 20);
            }
            form.label1.Text += "\n";


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        form.label1.Text += reader[i] + new string(' ', 20);
                    }

                    form.label1.Text += "\n";
                }
            }
        }
    }
}
