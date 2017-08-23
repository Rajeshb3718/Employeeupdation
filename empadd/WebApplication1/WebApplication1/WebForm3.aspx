<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
            <table>
        <tr> <td>   Name:   </td><td>  <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td></tr>
          <tr> <td>  Emp No:  </td><td>  <asp:TextBox ID="txtNo" runat="server"></asp:TextBox></td></tr>
          <tr> <td>  Salary: </td><td>   <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox></td></tr>
          <tr> <td>  Hiredate: </td><td> <asp:TextBox ID="txtDate" runat="server"></asp:TextBox></td></tr>
       
           
                </table> 
         <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
