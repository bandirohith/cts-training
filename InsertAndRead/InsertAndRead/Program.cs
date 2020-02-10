using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRead
{
    class Program
    {
        public static void Read()
        {
            string connectionstring = @"Data Source=BLT1048\SQLEXPRESS2014;Initial Catalog=restaurent;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();

            SqlCommand cmd;

            cmd = new SqlCommand("select * from Restaurent",con);

            SqlDataReader sd = cmd.ExecuteReader();

            while(sd.Read())
            {
                Console.WriteLine("{0}{1}{2}", sd[0], sd[1], sd[2]);
            }
        }
        public static void Write()
        {
            string connectionstring = @"Data Source=BLT1048\SQLEXPRESS2014;Initial Catalog=restaurent;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();

            SqlCommand cmd;

            if (RecordAvailable("select count (*) from Restaurent where restaurentName='AndhraMess'"))
            {
                Console.WriteLine("a restaurent with is already exists");
            }
            else
            {
                cmd = new SqlCommand("insert into Restaurent values('AndhraMess','9 am to 4 pm','veg')", con);

                cmd.ExecuteNonQuery();
            }
           
        }
        public static Boolean RecordAvailable(string query)
        {

            string connectionstring = @"Data Source=BLT1048\SQLEXPRESS2014;Initial Catalog=restaurent;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();
            SqlCommand cmd;

            cmd = new SqlCommand(query, con);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                return true;

            }
            else
                return false;

        }


            static void Main(string[] args)
            {

                    Write();
                    Read();
            Console.ReadKey();
            }
    }
}
