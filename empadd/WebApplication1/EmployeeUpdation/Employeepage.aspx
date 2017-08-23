<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employeepage.aspx.cs" Inherits="EmployeeUpdation.Employeepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
        }
        .auto-style2 {
            width: 290px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width: 100%;">
                <tr>
                    <td class="auto-style1">Name:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Enter Name" ForeColor="#FF3300">*</asp:RequiredFieldValidator></td>
                    <td rowspan="5">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Job:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtJob" runat="server"></asp:TextBox></td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Salary: </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox></td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSalary" ErrorMessage="Enter Salary" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSalary" ErrorMessage="Salary Range Should be Between 2000 and 5000" ForeColor="#FF3300" MaximumValue="5000" MinimumValue="2000" Type="Integer">*</asp:RangeValidator>
                    </td>
                </tr>
        <tr>
                    <td class="auto-style1">HireDate</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtHiredate" runat="server" TextMode="Date"></asp:TextBox></td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Comm</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtComm" runat="server"></asp:TextBox></td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Deptno</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDeptno" runat="server"></asp:TextBox></td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
        </table>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Add Employee and go to Department page" OnClick="Button1_Click" />
    </form>
</body>
</html>
