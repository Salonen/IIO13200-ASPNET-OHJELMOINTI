<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kino.aspx.cs" Inherits="Tyontekijat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Työntekijät</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnHae" runat="server" Text="Hae työntekijät" OnClick="btnHae_Click" />
        <div id="esitys">
             <h2>Työntekijämme</h2>
            <asp:Repeater ID="Repeater1" runat="server" >
        <ItemTemplate>
            <asp:Image ID="Image1" Width="150px" ImageUrl='<%# Container.DataItem  %>' runat="server" /> 
        </ItemTemplate>
    </asp:Repeater>
            <asp:GridView 
                ID="gvData" runat="server"></asp:GridView>
        </div>
        <div id="footer">
            <asp:Label ID="lblMessages" 
                runat="server" 
                Text="..."></asp:Label>
        </div>
    </div>
        <asp:TextBox ID="TextBox1" runat="server" Height="100px" Width="1435px"></asp:TextBox>
        <asp:ListBox ID="ListBox1" runat="server" Height="217px" Width="353px"></asp:ListBox>
        <asp:TextBox ID="TextBox2" runat="server" Height="246px" Width="422px" TextMode="MultiLine"></asp:TextBox>
    </form>
</body>
</html>

