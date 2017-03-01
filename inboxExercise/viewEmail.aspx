<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="viewEmail.aspx.cs" Inherits="inboxExercise.viewEmail" %>
<% @Import Namespace="System.Data.SqlClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display: inline-block">
            <asp:Button ID="buttonDelete" runat="server" OnClick="buttonDelete_Click" Text="Delete" />
&nbsp;<br /><label for="textBoxEmail">From: </label>
            <%
                Response.Write(Request["EmailId"]);
                SqlConnection con;
                SqlCommand cmd;
                SqlDataReader reader;
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = (string.Format("select * from Emails where EmailId = '{0}'", Request["EmailId"]));

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Response.Write(string.Format("<input type='text' name = 'textBoxEmail' id='textBoxEmail' value = '{0}'/>", reader["FromUser"].ToString()));
                    Response.Write("<br/><label for='textBoxText'>Body:</label>");
                    Response.Write(string.Format("<br/><textarea rows = '10' cols = '50' name = 'textAreaBody' id='textAreaBody'>{0}</textarea>", reader["Text"].ToString()));
                }
                %>
            <br /><asp:Button ID="buttonReply" runat="server" Text="Reply" OnClick="buttonReply_Click" />
    </div>
    
    
</asp:Content>
