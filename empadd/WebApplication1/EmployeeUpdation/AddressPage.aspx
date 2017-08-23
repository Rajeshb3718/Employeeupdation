<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddressPage.aspx.cs" Inherits="EmployeeUpdation.AddressPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 168px;
        }
        .auto-style2 {
            width: 430px;
        }
        .auto-style3 {
            width: 291px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Add_no</td>
                <td class="auto-style3"> <asp:TextBox ID="txtAdd_no" runat="server" ></asp:TextBox> </td>
                <td class="auto-style2">
                    &nbsp;</td>
              
            </tr>
             <tr>
                <td class="auto-style1">Street:</td>
                <td class="auto-style3"><asp:TextBox ID="txtStreet" runat="server"></asp:TextBox></td>
                <td class="auto-style2"> &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">City:</td>
                <td class="auto-style3"><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
           
             <tr>
                <td class="auto-style1">Zipcode:</td>
                <td class="auto-style3"><asp:TextBox ID="txtZipcode" runat="server"></asp:TextBox></td>
                <td class="auto-style2">&nbsp;</td>
                  </tr>
        </table>
        
    </div>
        <asp:Button ID="Button1" runat="server" Text="Add Address" OnClick="Button1_Click"  />
       <asp:Button ID="Button2" runat="server" Text="Add Employee details to Database" OnClick="Button2_Click"  />
   
    
    </form>
</body>
</html>
