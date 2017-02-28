<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewEmailPage.aspx.cs" Inherits="inboxExercise.viewEmailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%Response.Write(string.Format("<title>{0}: {1}</title>", Session["From"], Session["Subject"])); %>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    
    </div>
    </form>
</body>
</html>
