﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationEventsDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("no of applications" + Application["TotoalApplications"]);
            Response.Write("<br/>");
            Response.Write("total number of users" + Application["totaluserssession"]);


        }
    }
}