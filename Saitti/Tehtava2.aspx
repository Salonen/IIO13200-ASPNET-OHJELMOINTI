<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava2.aspx.cs" Inherits="Tehtava2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lotto</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Arvo numerot" OnClick="Button1_Click" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="229px" Width="169px"></asp:TextBox>
        </p>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="55px" style="margin-bottom: 28px" Width="318px">
        </asp:DropDownList>
    </form>
</body>
</html>
