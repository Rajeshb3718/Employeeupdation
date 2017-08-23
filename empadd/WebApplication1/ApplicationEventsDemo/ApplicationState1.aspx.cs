using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationEventsDemo
{
    public partial class ApplicationState1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["count"] == null)
                {
                    Application["count"] = "0";
                }
                TextBox1.Text = Application["count"].ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ClickCount = Convert.ToInt16(Application["count"]) + 1;
            TextBox1.Text = ClickCount.ToString();
            Application["count"] = ClickCount;


        }
    }
}