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
       <!-- &nbsp;-->
        
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <p>
        
        <img id="image" src="" runat="server" style="height: 132px; width: 131px"/>
        <img id="image2" src="" runat="server" style="height: 132px; width: 131px" />
        <img id="image3" src="" runat="server" style="height: 132px; width: 131px" />
        <img id="image4" src="" runat="server" style="height: 132px; width: 131px" />
        <img id="image5" src="" runat="server" style="height: 132px; width: 131px" />
        <img id="image6" src="" runat="server" style="height: 132px; width: 131px" />
        <img id="image7" src="" runat="server" style="height: 132px; width: 131px" />
            
        </p>
    <img id="image8" src="" runat="server"/>
        <p>
        <asp:TextBox ID="TextBox1" Text="1" runat="server" TextMode="MultiLine" Height="100px" Width="627px"></asp:TextBox>
            Anna kuvan numero 1-5
            <asp:ListBox ID="ListBox1" runat="server" Height="99px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="margin-top: 0px" Width="514px"></asp:ListBox>
        </p>
    </form>
    </body>
</html>
