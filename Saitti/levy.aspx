<%@ Page Language="C#" AutoEventWireup="true" CodeFile="levy.aspx.cs" Inherits="levy" %>

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
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="173px" Width="362px" TextMode="MultiLine"></asp:TextBox>
            <asp:Repeater ID="Repeater1" runat="server">
            </asp:Repeater>
        </p>
        <asp:Image ID="Image1" runat="server" Height="101px" Width="113px" />
        <img src="images/Anna2009.jpg" alt="Sample" />
        
        <img id="image" src="images/Paula2012.JPG" runat="server" />
        <asp:Image ID="Image2" runat="server" Height="105px" Width="124px" />
    </form>
</body>
</html>
