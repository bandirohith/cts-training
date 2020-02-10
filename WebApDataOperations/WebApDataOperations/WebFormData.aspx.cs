using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApDataOperations
{
    public partial class WebFormData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ADOlayer ado = new ADOlayer();
            
            var stlist = ado.Getallrecords();

            GridView1.DataSource = stlist;

            GridView1.DataBind();
        }
    }
}