<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Source.aspx.cs" Inherits="Redirect.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="Button1" runat="server" Text="response redirect" OnClick="Button1_Click1" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="server transfer" OnClick="Button2_Click" />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Cross page postback" PostBackUrl="~/Target.aspx" />

        </div>
    </form>
    <p>
        <a href="Target.aspx">Target.aspx</a></p>
</body>
</html>
