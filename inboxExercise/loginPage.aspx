<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="inboxExercise.loginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Create Account" />
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Red" />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Blue" />
        <asp:RadioButton ID="RadioButton3" runat="server" Text="Yellow" />
        <br />
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
