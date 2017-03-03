<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="deletedPage.aspx.cs" Inherits="inboxExercise.deletedPage" %>
<% @Import Namespace="System.Data.SqlClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="tableInbox">
        <tr>
            <th></th>
            
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
                cmd.CommandText = (string.Format("select * from Emails where ToUser = '{0}' and Status = 'D'", Session["User"]));

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Response.Write(string.Format("<tr><td><input type='button' name='restore' value='{0}'/></td>", reader["EmailId"]));
                    Response.Write(string.Format("<td>{0}</td>", reader["FromUser"]));
                    Response.Write(string.Format("<td><a href = 'viewEmail.aspx?emailId={0}' />{1}</td>", reader["EmailId"], reader["Subject"]));
                    Response.Write(string.Format("<td>{0}</td></tr>", reader["Date"]));
                }
            %>

        </table>
</asp:Content>
