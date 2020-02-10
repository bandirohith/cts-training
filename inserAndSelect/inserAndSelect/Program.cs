using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inserAndSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = @"Data Source=BLT1048\SQLEXPRESS2014;Initial Catalog=restaurent;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();

            SqlCommand cmd;
            string name = "Vaanga Sappdalaa";
            string timings = "9 Am to 6 pm";
            string type = "veg&nonveg";
            // string query= "insert into Restaurent values('"+name+"','"+timings+"','"+type+"' )";

            string query = "update Restaurent set restaurentType='veg' where restaurentName='Vaanga Sappdalaa'";

            cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();


            


      
        }
    }
}
