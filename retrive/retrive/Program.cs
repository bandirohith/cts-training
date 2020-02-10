using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retrive
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = @"Data Source=BLT1048\SQLEXPRESS2014;Initial Catalog=restaurent;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();

            SqlCommand cmd;

            string query = "select * from Restaurent";

            cmd = new SqlCommand(query, con);

            SqlDataReader sd = cmd.ExecuteReader();

            while(sd.Read())
            {
                Console.WriteLine("{0}{1}{2}", sd[0],sd[1],sd[2]);
            }
        }
    }
}
