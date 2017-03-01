<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="inboxPage.aspx.cs" Inherits="inboxExercise.inboxPage" %>
<% @Import Namespace="System.Data.SqlClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Inbox</h3><br />
        <asp:Button ID="buttonCompose" runat="server" Text="Compose" />
    &nbsp;
        <asp:Button ID="buttonAddressBook" runat="server" Text="Address Book" />
    &nbsp;
        <a href="deletedPage.aspx"><input type="button" value="Deleted Emails" /></a> 

    <br />
    <table id="tableInbox">
        <tr>
            <th>
                <asp:Button ID="buttonDelete" runat="server" OnClick="buttonDelete_Click" Text="delete" />
            </th>
            <th>From</th>
            <th>Subject</th>
            <th>Date</th>
        </tr>
        <%
            Session["User"] = "xyz";
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader reader;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = (string.Format("select * from Emails where ToUser = '{0}' and Status != 'D'", Session["User"]));

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Response.Write(string.Format("<tr><td><input type='checkbox' name='delete' value='{0}'/></td>", reader["EmailId"]));
                Response.Write(string.Format("<td>{0}</td>", reader["FromUser"]));
                Response.Write(string.Format("<td><a href = 'viewEmail.aspx?emailId={0}' />{1}</td>", reader["EmailId"], reader["Subject"]));
                Response.Write(string.Format("<td>{0}</td></tr>", reader["Date"]));
            }


                %>

    </table>
    
    

</asp:Content>
