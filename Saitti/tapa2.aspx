<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tapa2.aspx.cs" Inherits="tapa2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Kohde 1:
        </h1>
        <p>
            <asp:Button ID="QS"
                runat="server" Text="Käytä QS" OnClick="QS_Click" />
            
            <br />
            <asp:Button ID="posta"
                runat="server" Text="Käytä post" OnClick="posta_Click" />
            <%=Request.QueryString["Data"] %>
        </p>
    
    </div>
    </form>
</body>
</html>
<!--Sivulle lähetettiin pa viesti-->