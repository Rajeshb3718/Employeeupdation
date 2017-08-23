<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeptPage.aspx.cs" Inherits="EmployeeUpdation.DeptPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 253px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Department Name:</td>
                <td> <asp:TextBox ID="txtDeptName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDeptName" ErrorMessage="Enter valid Department name" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Departmetn Location:</td>
                <td><asp:TextBox ID="txtDeptLocation" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDeptName" ErrorMessage="Enter required Department Location" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
           
          

        </table>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Add department and go to  address page" OnClick="Button1_Click" />
    </form>
</body>
</html>
