﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava1.aspx.cs" Inherits="Tehtava1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="http://www.w3schools.com/lib/w3.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 360px">
    <form id="form1" runat="server">
    <div class="w3-container w3-light-green">
    

        <p>Leveys</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> mm
        <p>Korkeus</p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> mm
        </p>
        <p>Karmin leveys</p>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> mm
        <p>
            <asp:Button ID="Button1" Class="w3-btn w3-blue" runat="server" Text="Laske tarjoushinta" OnClick="Button1_Click1" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>Ikkunan Pinta-ala</p>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox> m2
        <p>Karmin piiri</p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" style="margin-bottom: 0px"></asp:TextBox> m
        </p>
        <p>Tarjoushinta (ilman ALV)</p>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox> Euroa
            </div>
    </form>
</body>
</html>
