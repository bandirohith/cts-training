using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class InsertData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insert_rec(object sender, EventArgs e)
        {
            TraineeDataLayer tdl = new TraineeDataLayer();
            Trainee t1 = new Trainee();
            t1.tid = TextBox1.Text;
            t1.name = TextBox2.Text;
            t1.location = TextBox3.Text;
            t1.techdomain = TextBox4.Text;
            t1.startdate = Convert.ToDateTime(TextBox5.Text);
            string ex=tdl.insertRec(t1.tid,t1.name,t1.location,t1.techdomain,t1.startdate);
            Label1.Text = ex;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}