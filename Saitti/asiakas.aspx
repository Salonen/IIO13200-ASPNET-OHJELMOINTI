<%@ Page Language="C#" AutoEventWireup="true" CodeFile="asiakas.aspx.cs" Inherits="asiakas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="79px" style="margin-bottom: 43px" Width="1293px"></asp:TextBox>
        <asp:ListBox ID="ListBox1" runat="server" Height="85px" Width="199px"></asp:ListBox>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
