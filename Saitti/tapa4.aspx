<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tapa4.aspx.cs" Inherits="tapa4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>tapa 3 :käytetään Session</h1>
           Sessionista luettu viesti:
        <%=Session["Viesti"] %>
    </div>
    </form>
</body>
</html>
