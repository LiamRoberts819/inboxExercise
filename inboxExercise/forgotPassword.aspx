<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgotPassword.aspx.cs" Inherits="inboxExercise.forgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        E-mail Address:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Security Answer:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Reset Password:" />
        <br />
        <br />
        Current Password: <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <br />
        Enter New Password:
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Enabled="False" OnClick="Button2_Click" Text="Change Password" />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
