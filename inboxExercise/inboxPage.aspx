<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="inboxPage.aspx.cs" Inherits="inboxExercise.inboxPage" %>
<% @Import Namespace="System.Data.SqlClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <h3>Inbox</h3>
        <asp:Button ID="buttonCompose" runat="server" Text="Compose" />
    &nbsp;
        <asp:Button ID="buttonAddressBook" runat="server" Text="Address Book" />
    &nbsp;
        <asp:Button ID="buttonInbox" runat="server" OnClick="buttonInbox_Click" Text="Inbox" />
&nbsp;
        <asp:Button ID="buttonDeletedPage" runat="server" Text="Deleted Emails" OnClick="buttonDeletedEmails_Click" />

    &nbsp;
    <asp:Button ID="buttonSent" runat="server" OnClick="buttonSent_Click" Text="Sent Emails" />

    <br />

    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmailId">
        <Columns>
            <asp:TemplateField HeaderText="EmailId" InsertVisible="False" SortExpression="EmailId" Visible="False">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("EmailId") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("EmailId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:CheckBox runat="server" ID="checkBoxDelete"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ToUser" SortExpression="ToUser">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ToUser") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("ToUser") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Subject" SortExpression="Subject">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Subject") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton PostBackUrl='<%#Eval("EmailId",@"viewEmail.aspx?emailId={0}") %>' ID="Label1" runat="server" Text='<%# Bind("Subject") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date" SortExpression="Date">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Date") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Date") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnectionString %>" SelectCommand="SELECT [Subject], [ToUser], [Date], [EmailId] FROM [Emails]">
</asp:SqlDataSource>
    <br />
    <asp:Button ID="buttonDelete" runat="server" OnClick="buttonDelete_Click1" Text="Delete" />
    <br />

    

    
</asp:Content>
