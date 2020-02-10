using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class SearchData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Search_rec(object sender, EventArgs e)
        {
            TraineeDataLayer tdl = new TraineeDataLayer();
            //Trainee t1 = new Trainee();
            string s= TextBox1.Text;
            var list= tdl.searchRec(s);
            GridView1.DataSource =list ;
            GridView1.DataBind();
        }

       
    }
}