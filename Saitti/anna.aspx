<%@ Page Language="C#" AutoEventWireup="true" CodeFile="anna.aspx.cs" Inherits="anna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        PVM:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            Nimi
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        Olen oppinut
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <p>
            Haluan oppia
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        Hyvää
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <p>
            Paranettevaa
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
        Muuta
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Lähetä palaute" OnClick="Button1_Click" />
        <p>
            <asp:Button ID="Button2" runat="server" Text="Näytä palaute" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Lue MySQL" Width="78px" OnClick="Button3_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox8" runat="server" TextMode="MultiLine" Height="78px" Width="1223px"></asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server" TextMode="MultiLine" Height="75px" Width="1217px"></asp:TextBox>
    </form>
</body>
</html>
