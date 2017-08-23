using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        int ClicksCount = 0;
        //Employee emp;
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
                //emp = new Employee();
                txtName.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(ViewState["example"]!=null)
            {
                //emp.Empname = txtName.Text;
                //emp.Empno = Convert.ToInt32(txtNo.Text);
                //emp.Salary = Convert.ToInt32(txtSalary.Text);
                ClicksCount = (int)ViewState["example"] + 1;       
         }
            txtName.Text = ClicksCount.ToString();
            ViewState["example"] = ClicksCount;
        }
    }
}