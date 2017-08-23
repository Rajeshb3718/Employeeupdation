using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationEventsDemo
{
    public partial class ViewState1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["count"] == null)
                {
                    ViewState["count"] = "0";
                }
                TextBox1.Text = ViewState["count"].ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ClickCount = Convert.ToInt16(ViewState["count"]) + 1;
            TextBox1.Text = ClickCount.ToString();
            ViewState["count"] = ClickCount;


        }
    }
}