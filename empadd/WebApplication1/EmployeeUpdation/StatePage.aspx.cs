using Employee.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeUpdation
{
    public partial class StatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StateClass state1 = new StateClass();
            state1.StateName = txtStateName.Text;
            state1.StateAbbr = txtStateAbbr.Text;
            state1.StateId = 12;
            Session["State"] = state1;
            Response.Redirect("EmployeePage.aspx");
        }
    }
}