<%@ Page Language="C#" AutoEventWireup="true" CodeFile="t3.aspx.cs" Inherits="t3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%=Request.Form["txtMessage"] %>
    </div>
    </form>
</body>
</html>
