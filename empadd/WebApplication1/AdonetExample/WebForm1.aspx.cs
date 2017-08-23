using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;
//using System.Data.Oracleclient;

using Oracle.ManagedDataAccess.Client;

namespace AdonetExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    //        SqlConnection conn = new SqlConnection("data source=.; database=Scott;integrated security=SSPI");
    //        SqlCommand cmd = new SqlCommand("select * from emp", conn);
    //        conn.Open();
    //SqlDataReader rdr=cmd.ExecuteReader();
    //GridView1.DataSource = rdr;
    //GridView1.DataBind();
    //conn.Close();


    //        OracleConnection conn = new OracleConnection("DATA SOURCE=XE;PASSWORD=tiger;PERSIST SECURITY INFO=True;USER ID=SCOTT");
    //        OracleCommand cmd = new OracleCommand("select * from dept", conn);
    //conn.Open();
    //OracleDataReader rdr = cmd.ExecuteReader();
    //GridView1.DataSource = rdr;
    //GridView1.DataBind();
            //conn.Close();
            OleDbConnection conn = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAPTOP-7QM0ONKQ;Integrated Security=SSPI;Initial Catalog=Scott");

    OleDbCommand cmd = new OleDbCommand("select * from address", conn);
    conn.Open();
    OleDbDataReader rdr = cmd.ExecuteReader();
    GridView1.DataSource = rdr;
    GridView1.DataBind();
    OleDbCommand cmd1 = new OleDbCommand("select ename,job,dname,loc,sal from emp inner join dept on emp.deptno=dept.deptno", conn);
  
    //OleDbDataReader rdr1 = cmd1.ExecuteReader();
    //GridView2.DataSource = rdr1;
    //GridView2.DataBind();
    //conn.Close();
        }
    }
}
