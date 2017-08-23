using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Employee emp ;
        protected void Page_Load(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if(!IsPostBack)
            {
                emp=new Employee();
                emp.Empname = txtName.Text;
                emp.Empno = Convert.ToInt32(txtNo.Text);
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                emp.HireDate = Convert.ToDateTime(txtDate.Text);



            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["click"] = emp;
        }
    }
}