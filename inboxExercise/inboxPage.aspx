<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="inboxPage.aspx.cs" Inherits="inboxExercise.inboxPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Inbox</h3><br />
        <asp:Button ID="buttonCompose" runat="server" Text="Compose" />
&nbsp;
        <asp:Button ID="buttonAddressBook" runat="server" Text="Address Book" />
    <br />
    <table name="tableInbox" id="tableInbox">
        <tr>
            <th>delete</th>
            <th>From</th>
            <th>Subject</th>
            <th>Date</th>
        </tr>
        <%

            <tr>

        </tr>
    </table>
    
    

</asp:Content>
