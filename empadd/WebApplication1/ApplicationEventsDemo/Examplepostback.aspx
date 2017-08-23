<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examplepostback.aspx.cs" Inherits="ApplicationEventsDemo.Examplepostback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Details Form</title>
    <style type="text/css">
        .auto-style1 {
            width: 132px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 46%;" >
           <tr><td colspan="2" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Employee Details Form </strong> </td></tr> 
            <tr>
                <td class="auto-style1">First Name</td>
                <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style1">Last Name</td>
                <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
              
            </tr>
            <tr>
                <td class="auto-style1">City</td>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server" ></asp:DropDownList></td>
                
            </tr>
        </table>
    </div>&nbsp&nbsp&nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp&nbsp
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register employee" />
    </form>
</body>
</html>
