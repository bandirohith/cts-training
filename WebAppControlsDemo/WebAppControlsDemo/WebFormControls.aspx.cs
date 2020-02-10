using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppControlsDemo
{
    public partial class WebFormControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_func(object sender, EventArgs e)
        {
            string data = "";
            string name = textName.Text;
            string dob = calender1.SelectedDate.ToString();
            string gender = RadioButtonList1.SelectedItem.Value.ToString();
            string hobby = "";
            if(CheckBoxList1.Items[0].Selected)
            {
                hobby = CheckBoxList1.Items[0].Value;
            }
            if (CheckBoxList1.Items[1].Selected)
            {
                hobby = CheckBoxList1.Items[1].Value;
            }
            if (CheckBoxList1.Items[2].Selected)
            {
                hobby = CheckBoxList1.Items[2].Value;
            }
            if (CheckBoxList1.Items[3].Selected)
            {
                hobby = CheckBoxList1.Items[3].Value;
            }
            string education = DropDownList1.SelectedItem.Value;

            data += " "+ name + " " + dob + " " + gender + " " + hobby; 
        }
    }
}