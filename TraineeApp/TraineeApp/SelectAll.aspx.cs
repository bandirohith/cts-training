using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class SelectAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Get_All(object sender, EventArgs e)
        {
            TraineeDataLayer tdl = new TraineeDataLayer();
            
            
            var list = tdl.getALL();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}