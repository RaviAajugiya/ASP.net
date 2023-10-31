<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBox.aspx.cs" Inherits="ASP.net_Introduction.ListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:ListBox ID="ListBox1" runat="server">
                            <asp:ListItem Value="R">Red</asp:ListItem>
                            <asp:ListItem Value="G">Green</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="&gt;" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="&lt;" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <asp:ListBox ID="ListBox2" runat="server">
                            <asp:ListItem Value="B">Black</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
            </table>
        </div>


        <asp:ListBox ID="ListBox3" runat="server" OnSelectedIndexChanged="ListBox3_SelectedIndexChanged">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
        </asp:ListBox>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" OnClick="ImageButton1_Click" Width="36px" />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <asp:RadioButton ID="RadioButton2" runat="server" />
        <asp:RadioButton ID="RadioButton3" runat="server" />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>one</asp:ListItem>
            <asp:ListItem>two</asp:ListItem>
        </asp:CheckBoxList>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
        </asp:DropDownList>


    </form>
</body>
</html>
