using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationEventsDemo
{
    public partial class RadiobuttonExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(radMale.Checked)
            {
                Response.Write("your Gender is:" + radMale.Text + "<br/>");
            }
            if (radFemale.Checked )
            {
                Response.Write("your Gender is:" + radFemale.Text + "<br/>");
            }
            if (radUnknown.Checked )
            {
                Response.Write("your Gender is:" + radUnknown.Text + "<br/>");
            }

        }

        protected void radMale_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Male Radio button Selection chnged");
        }
    }
}