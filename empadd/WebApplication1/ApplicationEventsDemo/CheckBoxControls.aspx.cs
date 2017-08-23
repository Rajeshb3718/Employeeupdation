using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace ApplicationEventsDemo
{
    public partial class CheckBoxControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if(chkGraduate.Checked)
            {
                sb.Append(chkGraduate.Text);
            }
            if(chkPostGraduate.Checked)
                {
                    sb.Append(", "+ chkPostGraduate.Text);
                }
                if(chkDoctrate.Checked)
                {
                    sb.Append(", "+chkDoctrate.Text);
                }
                Response.Write("Your Selection are:" + sb.ToString());
        }
    }
}