using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationEventsDemo
{
    public partial class ControlsDemoExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            Response.Write("Button Click Event" + "<br/>");
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            Response.Write("Button ommand Event");
        }
    }
}