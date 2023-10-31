<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Source.aspx.cs" Inherits="Redirection.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="Target.aspx">Target.aspx</a><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Resopnse.Redirect" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Server.Transfer" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
