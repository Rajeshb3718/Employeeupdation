using Employee.PL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
namespace EmployeeUpdation
{
    public partial class AddressPage : System.Web.UI.Page
    {
        AddressClass add1 = new AddressClass();
        List<AddressClass> addresses = new List<AddressClass>();

        string ConnString = "Data Source=localhost;Initial Catalog=Scott;Integrated Security=True";
        SqlConnection Conn;
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<AddressClass> addresses = new List<AddressClass>();
            txtAdd_no.Text = add1.Add_no.ToString();
            //EmployeeClass emp1 = (EmployeeClass)Session["Emp"];
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AddressClass add1 = new AddressClass();
          
            add1.Street = txtStreet.Text;
            add1.City = txtCity.Text;
            
            add1.Zipcode = Convert.ToInt32(txtZipcode.Text);
            
            addresses.Add(add1);
            Session["Address"] = addresses;
           // EmployeeClass emp1 = (EmployeeClass)Session["Emp"];
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(ConnString);
            Conn.Open();
            SqlTransaction txState = Conn.BeginTransaction();
           
            try
            {

               //EmployeeClass Emp1 = (EmployeeClass)Session["Emp"];
               //DeptClass dept1 = (DeptClass)Session["Dept"];


               // StateClass State1 = (StateClass)Session["State"];
               //var ConnString = "Data Source=localhost;Initial Catalog=Scott;Integrated Security=True";
                EmployeeClass Emp1 = TestData.getEmployee();
              
                //Conn.Open();
                //  SqlTransaction txEmp = Conn.BeginTransaction();
                StringBuilder sbEmp = new StringBuilder();
                sbEmp.Append("Insert into emp(empno,Ename,Job,Hiredate,Sal,comm,deptno) values");
                sbEmp.Append("( " + Emp1.Empno + ",'" + Emp1.Name + "','" + Emp1.Job + "','");
                sbEmp.Append(Emp1.HireDate + "'," + Emp1.Salary + "," + Emp1.Comm + "," + Emp1.DeptNo + ")");
                string Empquery = sbEmp.ToString();
                SqlCommand daEmployee = new SqlCommand(Empquery, Conn,txState);
                int result = (int)daEmployee.ExecuteNonQuery();

                foreach(AddressClass add in Emp1.Addresses)
                {
                    StringBuilder sbState = new StringBuilder();
                    sbState.Append("Insert into state(code,abbr) values");
                    sbState.Append("( '" + add.state1.Code + "','" +  add.state1.Name + "'" + ")");
                    sbState.Append(";Select CAST(SCOPE_IDENTITY() AS INT)");
                    string Statequery = sbState.ToString();
                    SqlCommand cmd = new SqlCommand(Statequery, Conn, txState);
                    int StateId =(int) cmd.ExecuteScalar();


                    //   SqlTransaction txAddress = Conn.BeginTransaction();
                    StringBuilder sbAddress = new StringBuilder();
                    sbAddress.Append("Insert into Address(street,city,stateid,zipcode,empno) values");
                    sbAddress.Append("( '" + add.Street + "','" + add.City + "'," + StateId + "," + add.Zipcode +","+ Emp1.Empno+")");
                    string Addressquery = sbAddress.ToString();
                    SqlCommand daAddress = new SqlCommand(Addressquery, Conn, txState);
                    int result1 = daAddress.ExecuteNonQuery();

                }

             
                


             

               //// SqlTransaction txDept = Conn.BeginTransaction();
               // StringBuilder sbDept = new StringBuilder();
               // sbDept.Append("Insert into dept(dname,loc) values");
               // sbDept.Append("( " + "'" + "Emp1.dept.Deptname" + "','" + "Emp1.dept.Deptlocation" + "'" + ")");
               // string Deptquery = sbDept.ToString();
               // SqlDataAdapter daDept = new SqlDataAdapter(Deptquery, Conn);



            

                txState.Commit();
                //txEmp.Commit();
                //txDept.Commit();
                //txAddress.Commit();
                





            }
            catch(Exception ex)
            {
                txState.Rollback();
                Response.Write(ex.Message);
            }
            //finally
            //{
            //    Conn.Close();
            //}
        }

       
    }
}