using System;
using Employee.PL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeUpdation
{
    public partial class DeptPage : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeClass employee=new EmployeeClass();
            DeptClass dept1 = new DeptClass();
            //if (ViewState["dept"] != null)
            //{
            //    dept1 = (Deptt)ViewState["adds"];
            //dept1.Deptname = ;
           // dept1.Deptlocation = ;
            employee.dept.Deptname = txtDeptName.Text;
            employee.dept.Deptlocation = txtDeptLocation.Text;
            Session["Dept"] = dept1;
            Response.Redirect("AddressPage.aspx");
        }
    }
}