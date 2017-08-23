<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBoxControls.aspx.cs" Inherits="ApplicationEventsDemo.CheckBoxControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
    <legend><pre>Education</pre></legend>
        <asp:CheckBox ID="chkGraduate" runat="server" text="Graduate" />
        <br />
        <asp:CheckBox ID="chkPostGraduate" runat="server" text="Post Graduate"  />
        <br />
        <asp:CheckBox ID="chkDoctrate" runat="server" text="Doctrate" />
        <br />
        </fieldset>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
