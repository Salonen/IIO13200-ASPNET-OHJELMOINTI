﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="juna.aspx.cs" Inherits="Tyontekijat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Työntekijät</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnHae" runat="server" Text="Hae junat" OnClick="btnHae_Click" />
        <div id="esitys">
             <h2>Työntekijämme</h2>
            <asp:GridView 
                ID="gvData" runat="server"></asp:GridView>
             <asp:ListBox ID="ListBox2" runat="server" Width="278px"></asp:ListBox>
             <asp:TextBox ID="TextBox1" runat="server" Height="210px" Width="1843px" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div id="footer">
            <asp:Label ID="lblMessages" 
                runat="server" 
                Text="..."></asp:Label>
        </div>
    </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="176px" Width="314px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        <asp:TextBox ID="TextBox2" runat="server" Height="140px" style="margin-top: 0px" Width="330px" TextMode="MultiLine" ></asp:TextBox>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="105px" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" Width="143px">
        </asp:CheckBoxList>
    </form>
</body>
</html>
