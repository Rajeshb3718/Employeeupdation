<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadiobuttonExample.aspx.cs" Inherits="ApplicationEventsDemo.RadiobuttonExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
            <legend><b>&nbsp;Gender<br />
                </b></legend>
    <asp:radiobutton ID="radMale" text="Male" runat="server" AutoPostBack="False" OnCheckedChanged="radMale_CheckedChanged" GroupName="GenderName"></asp:radiobutton>
            <asp:radiobutton ID="radFemale" text="Female"  runat="server" GroupName="GenderName"></asp:radiobutton>
            <asp:radiobutton ID="radUnknown" text="Unknown"  runat="server" GroupName="GenderName"></asp:radiobutton>
                </fieldset>
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
