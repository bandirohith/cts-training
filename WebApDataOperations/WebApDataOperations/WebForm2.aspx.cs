using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApDataOperations
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update_button(object sender, EventArgs e)
        {
            ADOlayer ado = new ADOlayer();
            string ex=ado.updateRec(Convert.ToInt32(T1.Text), float.Parse(T2.Text.ToString()));
            label1.Text = ex;
        }
    }
}