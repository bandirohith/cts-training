using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace WebApDataOperations
{
    public partial class AddData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void button1_click(object sender, EventArgs e)
        {
            int eid = int.Parse(TextBox1.Text);
            string ename = Convert.ToString(TextBox2.Text);
            long ssn = long.Parse(TextBox3.Text);
            double esal = double.Parse(TextBox4.Text);
            DateTime dob = Convert.ToDateTime(TextBox5.Text);
            int did = int.Parse(TextBox6.Text);
            ADOlayer ado = new ADOlayer();
            ado.insertrecord(eid,ename,ssn,esal,dob,did);
            
            //string constr = "";
            //constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
            //try
            //{
            //    SqlConnection con = new SqlConnection(constr);

            //    con.Open();
            //    DataSet ds = new DataSet();
            //    
            //    string query="insert into Employee (EmployeeId,EmployeeName,SSN,EmployeeSalary,DOB,Deptid) values("+eid+",'"+ename+"',"+ssn+","+esal+",'"+dob+"',"+did+")";
            //    SqlCommand cmd = new SqlCommand(query, con);

            //   int i=cmd.ExecuteNonQuery();
        }
            //catch(Exception ex)
            //{
            //    label7.Text = ex.Message;
            //}
        
    }
}