<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatePage.aspx.cs" Inherits="EmployeeUpdation.StatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 193px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
           <%-- <tr>
                <td class="auto-style1">State ID:</td>
                <td><asp:TextBox ID="txtStateID" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter State ID" ControlToValidate="txtStateID" ForeColor="Red">*</asp:RequiredFieldValidator></td>
            </tr>--%>
            <tr>
                <td class="auto-style1">State Name:</td>
                <td> <asp:TextBox ID="txtStateName" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter State Name" ControlToValidate="txtStateName" ForeColor="Red">*</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">State Abbr:</td>
                <td><asp:TextBox ID="txtStateAbbr" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Abbr" ControlToValidate="txtStateabbr" ForeColor="Red">*</asp:RequiredFieldValidator></td>
            </tr>
        </table>
        
       
        
    </div>
        <asp:Button ID="Button1" runat="server" Text="Add state and go to employee page" OnClick="Button1_Click" />
    </form>
</body>
</html>
