using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApDataOperations
{
    public class ADOlayer
    {
        string connectionstr = "";
        DataSet ds = new DataSet();
        public ADOlayer()
        {
            connectionstr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public void insertrecord(int eid, string ename, long ssn, double esal, DateTime dob, int did)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@EmployeeId", eid);
                cmd.Parameters.AddWithValue("@EmployeeName", ename);
                cmd.Parameters.AddWithValue("@SSN", ssn);
                cmd.Parameters.AddWithValue("@EmployeeSalary", esal);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Deptid", did);
                cmd.CommandText = "insertrecord";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(ds);
                ad.Update(ds);


            }
            catch(Exception e)
            {
                
            }
          
        }
        public string updateRec(int eid,float esal)
        {
            string ex = "";
            try
            {
                SqlConnection con = new SqlConnection(connectionstr);

                con.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.AddWithValue("@EmployeeId", eid);

                cmd.Parameters.AddWithValue("@EmployeeSalary", esal);

                cmd.CommandText = "updaterecord";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = con;

                SqlDataAdapter ada = new SqlDataAdapter(cmd);

                ada.Fill(ds);

                ada.Update(ds);
            }
            catch(Exception e)
            {
                ex = e.Message;
            }
            return ex;
        }
        public DataSet Getallrecords()
        {
           
            try
            {
                SqlConnection con = new SqlConnection(connectionstr);

                SqlCommand cmd;

                string query = "select * from Employee";

                cmd = new SqlCommand(query, con);

                SqlDataAdapter ada = new SqlDataAdapter(cmd);

                ada.Fill(ds);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
    }
}