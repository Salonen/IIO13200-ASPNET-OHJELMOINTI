<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kino.aspx.cs" Inherits="Tyontekijat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Elokuvat</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnHae" runat="server" Text="Hae elokuvat" OnClick="btnHae_Click" />
        <div id="esitys">
             <h2>Elokuvat<asp:ListBox ID="ListBox1" runat="server" Height="215px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="margin-top: 0px" Width="266px"></asp:ListBox>
                 <asp:TextBox ID="TextBox3" runat="server" Height="199px" Width="158px" TextMode="MultiLine"></asp:TextBox>
             </h2>
            <asp:Repeater ID="Repeater1" runat="server" >
        <ItemTemplate>
            <asp:Image ID="Image1" Width="150px" ImageUrl='<%# Container.DataItem  %>' runat="server" /> 
        </ItemTemplate>
    </asp:Repeater>
        </div>
        <div id="footer">
            <asp:Label ID="lblMessages" 
                runat="server" 
                Text="..."></asp:Label>
        </div>
    </div>
        <asp:TextBox ID="TextBox2" runat="server" Height="246px" Width="422px" TextMode="MultiLine"></asp:TextBox>
    </form>
</body>
</html>

