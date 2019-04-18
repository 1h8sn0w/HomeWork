using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Station_sql
{
    static class ConnectionToBd
    {
        public static SqlConnection GetConnection()
        {
            string str = @"Data Source=.\sqlexpress;Initial Catalog=WeatherStation;Integrated Security=True;Pooling=False";

            SqlConnection con = new SqlConnection(str);
            con.Open();
            Form1 form = new Form1 {connectionStatusStrip = {Text = con.State.ToString()}};
            return con;
        }
    }
}
