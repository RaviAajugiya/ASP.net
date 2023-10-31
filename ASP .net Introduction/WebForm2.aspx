<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ASP.net_Introduction.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelDemo" runat="server" Text="This is Label"></asp:Label>

            <br />
        </div>
        <asp:RadioButton ID="rbnRed" runat="server" GroupName="color" Text="Red" OnCheckedChanged="rbnColor_CheckedChanged" AutoPostBack="True" />
        <asp:RadioButton ID="rbnGreen" runat="server" GroupName="color" Text="Green" OnCheckedChanged="rbnColor_CheckedChanged" AutoPostBack="True" />
        <asp:RadioButton ID="rbnBlue" runat="server" GroupName="color" Text="Blue" OnCheckedChanged="rbnColor_CheckedChanged" AutoPostBack="True" />

        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />

        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" ShowGridLines="True" Width="220px">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
        <br />

    </form>
</body>
</html>
