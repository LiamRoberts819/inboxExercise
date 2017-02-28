<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="inboxPage.aspx.cs" Inherits="inboxExercise.inboxPage" %>
<% @Import Namespace="System.Data.SqlClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Inbox</h3><br />
        <asp:Button ID="buttonCompose" runat="server" Text="Compose" />
&nbsp;
        <asp:Button ID="buttonAddressBook" runat="server" Text="Address Book" />
    <br />
    <table id="tableInbox">
        <tr>
            <th>delete</th>
            <th>From</th>
            <th>Subject</th>
            <th>Date</th>
        </tr>
        <%
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader reader;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = (string.Format("select * from Emails where ToUser = '{0}'", Session["User"]));

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Response.Write(string.Format("<tr><td>{0}</td><td>{1}</td>", "  ", reader["From"]));
                Response.Write(string.Format("<td>{0}</td><td><a href = 'viewEmail.aspx?emailId={1}' />{2}</td>", "  ",reader["EmailId"], reader["Subject"]));
                Response.Write(string.Format("<td>{0}</td><td>{1}</td></tr>", "  ", reader["Date"]));
            }


                %>

    </table>
    
    

</asp:Content>
