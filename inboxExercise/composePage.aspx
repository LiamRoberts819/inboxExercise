<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="composePage.aspx.cs" Inherits="inboxExercise.composePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label for ="textBoxTo">To: </label>
                <%
                    if (Session["replyEmail"] != null)
                        Response.Write(string.Format("<input type ='text' name ='textBoxTo' id ='textBoxTo' value = '{0}'/><br />", Session["replyEmail"]));

                    else
                        Response.Write("<input type ='text' name ='textBoxTo' id ='textBoxTo'/><br />");
             %>
        <label for ="textBoxCc">Cc: </label>
        <input type ="text" name="textBoxCc" id="textBoxCc" /><br />
        <label for ="textBoxSubject">Subject: </label>
        <input type ="text" name="textBoxSubject" id="textBoxSubject" /><br />
        <textarea rows="4" cols="50" name="emailText" id="emailText">
        </textarea>
        <input type="button" runat="server" value ="Send" />
        <%Session["replyEmail"] = null; %>
    </div>
    </form>
</body>
</html>
