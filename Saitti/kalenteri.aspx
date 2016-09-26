<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kalenteri.aspx.cs" Inherits="kalenteri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        syntymäpäivä<asp:TextBox ID="TextBox1" runat="server" Width="341px"></asp:TextBox>
        <p>
        tämä päivä<asp:TextBox ID="TextBox2" runat="server" Width="344px"></asp:TextBox>
        </p>
        ero1<asp:TextBox ID="TextBox3" runat="server" Width="315px"></asp:TextBox>

        <p>
        ero2<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>

        Lopullinen ero<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

    </form>
</body>
</html>
