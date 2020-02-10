using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class UpdateRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update_rec(object sender, EventArgs e)
        {

            {
                TraineeDataLayer tdl = new TraineeDataLayer();

                string s = TextBox1.Text;
                string name = TextBox2.Text;
                tdl.updateRec(s, name);



            }
        }
    }
}