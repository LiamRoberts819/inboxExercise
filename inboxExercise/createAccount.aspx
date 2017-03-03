<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createAccount.aspx.cs" Inherits="inboxExercise.WebForm1" MasterPageFile="~/BGColour.Master" %>


<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Address:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Email Address:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Re-Enter Password:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        Security Question:
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        Security Answer:
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create" />

</asp:Content>
