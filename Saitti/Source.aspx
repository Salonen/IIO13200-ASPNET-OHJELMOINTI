<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Source.aspx.cs" Inherits="Source" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tiedonvälitysdemo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>S sivu</h1>
        <p>
        Lähettävä viesti: <asp:TextBox ID="txtMessages" runat="server" />
        <!-- tähän myöhemmin lista josta voi valita sop. val. lauseen-->
            <asp:DropDownList ID="ddlMessages" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged"></asp:DropDownList>
        <br />
            <asp:Button ID="buttonQueryString" 
                runat="server" Text="Käytä QueryString" OnClick="buttonQueryString_Click"
                />
            <asp:Button ID="post" 
                runat="server" Text="Käytä post" OnClick="post_Click"
                />
            <asp:Button ID="ses" 
                runat="server" Text="Käytä ses" OnClick="ses_Click"
                />
            <asp:Button ID="Cookie" 
                runat="server" Text="Käytä kek" OnClick="Cookie_Click"
                />
            <asp:Button ID="P" 
                runat="server" Text="Käytä public property" OnClick="P_Click"
                />
        </p>

    </div>
    </form>
</body>
</html>
