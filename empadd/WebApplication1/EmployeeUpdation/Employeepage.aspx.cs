using System;
using Employee.PL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeUpdation
{
    public partial class Employeepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeClass emp1 = new EmployeeClass();
            emp1.Name = txtName.Text;
            emp1.Job = txtName.Text;
            emp1.HireDate = Convert.ToDateTime(txtHiredate.Text);
            emp1.Salary = Convert.ToInt32(txtSalary.Text);
            emp1.Comm = Convert.ToInt32(txtComm.Text);
            emp1.DeptNo = Convert.ToInt32(txtDeptno.Text);
            Session["Emp"] = emp1;
            Response.Redirect("DeptPage.aspx"); 



        }
    }
}