<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="composePage.aspx.cs" Inherits="inboxExercise.composePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label for="textBoxTo">To: </label>
    <asp:TextBox ID="textBoxTo" runat="server"></asp:TextBox><br />

    <label for="textBoxCc">Cc: </label>    
    <asp:TextBox ID="textBoxCc" runat="server"></asp:TextBox><br />

    <label for="textBoxSubject">Subject:</label>
    <asp:TextBox ID="textBoxSubject" runat="server"></asp:TextBox><br />     
    
    <asp:TextBox ID="textBoxEmail" runat="server" Height="100px" TextMode="MultiLine" Width="300px"></asp:TextBox>
    <br />
        
    <asp:Button ID="buttonSend" runat="server" OnClick="buttonSend_Click" Text="Send" />

</asp:Content>
