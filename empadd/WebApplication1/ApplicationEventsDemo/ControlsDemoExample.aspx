<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlsDemoExample.aspx.cs" Inherits="ApplicationEventsDemo.ControlsDemoExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_OnClick" OnCommand="Button1_Command"/>
    </div>
    </form>
</body>
</html>
