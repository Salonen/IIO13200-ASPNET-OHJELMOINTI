<%@ Page Language="C#" AutoEventWireup="true" CodeFile="levy.aspx.cs" Inherits="levy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #image {
            margin-left: 84px;
            margin-top: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
        <asp:Image ID="Image1" runat="server" Height="101px" Width="113px" />
            <asp:TextBox ID="TextBox1" runat="server" Height="173px" Width="684px" TextMode="MultiLine" style="margin-left: 527px"></asp:TextBox>
            <asp:Repeater ID="Repeater1" runat="server">
            </asp:Repeater>
        </p>
        &nbsp;<img src="images/Anna2009.jpg" alt="Sample" style="height: 132px; width: 131px" />
        <asp:Image ID="Image2" runat="server" Height="105px" Width="124px" />
        <p>
        
        <img id="image" src="images/Paula2012.JPG" runat="server" /><asp:DataList ID="DataList1" runat="server" DataSourceID="joo">
            </asp:DataList>
        </p>
    </form>
</body>
</html>
