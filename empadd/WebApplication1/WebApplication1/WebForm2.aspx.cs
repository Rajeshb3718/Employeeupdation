using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int ClicksCount = 0;
                protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(ViewState["clicks"] != null)
            {
                ClicksCount = (int)ViewState["clicks"] + 1;
            }
            TextBox1.Text = ClicksCount.ToString();
            ViewState["clicks"] = ClicksCount;
         //   int nextpage =(int) ViewState["clicks"];


        }

        protected void nextpage_Click(object sender, EventArgs e)
        {
            int nextpage = (int)ViewState["clicks"];
            Response.Redirect("WebForm1.aspx");
        }
    }
}