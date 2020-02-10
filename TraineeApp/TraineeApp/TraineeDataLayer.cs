using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

namespace TraineeApp
{
    public class TraineeDataLayer
    {
        
        string connectionStr = "";
        DataSet ds = new DataSet();
        public TraineeDataLayer()
        {
            connectionStr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        }
        public string insertRec(string tid, string name, string location, string techdomain, DateTime startdate)
        {
            string i = "";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionStr))
                {
                    SqlCommand cmd = new SqlCommand();
                    //con.Open();
                    cmd.Parameters.AddWithValue("@Tid", tid);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@TechDomain", techdomain);
                    cmd.Parameters.AddWithValue("@StartDate", startdate);
                    cmd.CommandText = "insertrecord";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    da.Update(ds);
                    
                  
                }
            }
            catch (Exception ex)
            {
                i = ex.Message;
            }
            return i;
        }
        public DataSet searchRec(string tid)
        {
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@Tid", tid);
                cmd.CommandText = "searchrecord";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Update(ds);

            }
            return ds;
        }
        public void updateRec(string tid, string name)
        {
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@Tid", tid);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.CommandText = "updaterecord";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Update(ds);

            }

        }
        public DataSet getALL()
        {
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
               
                cmd.CommandText = "getall";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Update(ds);

            }
            return ds;

        }

    }
}