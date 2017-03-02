﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="inboxPage.aspx.cs" Inherits="inboxExercise.inboxPage" %>
<% @Import Namespace="System.Data.SqlClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%Session["User"] = "xyz";%>
    <h3>Inbox</h3>
        <asp:Button ID="buttonCompose" runat="server" Text="Compose" />
    &nbsp;
        <asp:Button ID="buttonAddressBook" runat="server" Text="Address Book" />
    &nbsp;
        <a href="deletedPage.aspx"><input type="button" value="Deleted Emails" /></a> 

    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:CheckBox runat="server" ID="checkBoxDelete"/>
                </ItemTemplate>
            </asp:TemplateField>                
            <asp:TemplateField HeaderText="FromUser" SortExpression="FromUser">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("FromUser") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("FromUser") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Subject" SortExpression="Subject">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Subject") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Subject") %>'></asp:Label>
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnectionString %>" SelectCommand="SELECT [FromUser], [Subject], [Date] FROM [Emails] WHERE ([ToUser] = @ToUser)">
        <SelectParameters>
            <asp:Parameter DefaultValue="xyz" Name="ToUser" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:Button ID="buttonDelete" runat="server" OnClick="buttonDelete_Click1" Text="Delete" />
    <br />

    

    
</asp:Content>
