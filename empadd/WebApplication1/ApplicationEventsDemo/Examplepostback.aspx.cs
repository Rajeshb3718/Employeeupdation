using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationEventsDemo
{
    public partial class Examplepostback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            LoadCityDropDownList();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        public void LoadCityDropDownList()
        {
            ListItem li1 = new ListItem("london");
            ddlCity.Items.Add(li1);
            ListItem li2 = new ListItem("sydney");
            ddlCity.Items.Add(li2);
            ListItem li3 = new ListItem("mumbai");
            ddlCity.Items.Add(li3);

        }
    }
}