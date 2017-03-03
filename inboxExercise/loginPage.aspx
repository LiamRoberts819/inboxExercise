<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="inboxExercise.loginPage" MasterPageFile="~/BGColour.Master" %>
<% @ MasterType VirtualPath="~/BGColour.master"%>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Create Account" />
        <br />
        <br />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" OnCheckedChanged="RadioButton3_CheckedChanged" Text="Yellow" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Blue" />
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="1" OnCheckedChanged="RadioButton4_CheckedChanged" Text="Red" />
        <br />

</asp:Content>