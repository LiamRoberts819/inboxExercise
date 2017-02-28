<% @Import Namespace="System.Data.SqlClient" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inboxPage.aspx.cs" Inherits="inboxExercise.inboxPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Button ID="buttonCompose" runat="server" Text="Compose" />
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Address Book" />

        <table>
            <tr>
                <th>
                    delete
                </th>
                <th>
                    From
                </th>
                <th>
                    Subject
                </th>
                <th>
                    Date
                </th>
            </tr>
            <%
                SqlConnection con;
                SqlCommand cmd;
                SqlDataReader reader;
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Administrator\Documents\Visual Studio 2015\Projects\ASP.Net\inboxExercise\inboxExercise\App_Data\inboxDatabase.mdf';Integrated Security=True");
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = string.Format("select * from emails where To = '{0}'", Session["userEmail"]);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Response.Write(string.Format("<tr><td>{0}</td>","  "));
                    Response.Write(string.Format("<td>{0}</td>",reader["From"]));
                    Response.Write(string.Format("<td>{0}</td>",reader["Subject"]));
                    Response.Write(string.Format("<td>{0}</td></tr>",reader["Date"]));
                }
                %>

        </table>
    
    </div>
    </form>
</body>
</html>
