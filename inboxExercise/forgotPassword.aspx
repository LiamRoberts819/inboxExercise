<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgotPassword.aspx.cs" Inherits="inboxExercise.forgotPassword" MasterPageFile="~/BGColour.Master" %>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
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
        Enter New Password:
        <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
        <br />
        Confirm New Password: <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBoxNewConfirm_TextChanged" Visible="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Enabled="False" OnClick="Button2_Click" Text="Change Password" />
        <br />
        <br />
        <br />
    

</asp:Content>
