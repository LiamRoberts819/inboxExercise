<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="composePage.aspx.cs" Inherits="inboxExercise.composePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label for="textBoxTo">To: </label>

    <%if (Session["replyEmail"] != null)
            Response.Write(string.Format("<input type='text' value = '{0}' name='textBoxTo' id='textBoxTo' /><br />", Session["replyEmail"]));
        else
            Response.Write("<input type='text' name='textBoxTo' id='textBoxTo' /><br />");
      %>
    <label for="textBoxCc">Cc: </label>
    <input type="text" name="textBoxCc" id="textBoxCc" /><br />
    Subject<label for="textBoxTo">: </label>
    <%if (Session["replyEmail"] != null)
            Response.Write(string.Format("<input type='text' value = 'Re: {0}' name='textBoxTo' id='textBoxTo' /><br />", Session["replySubject"]));
        else
            Response.Write("<input type='text' name='textBoxSubject' id='textBoxSubject' /><br />");
      %>
    <textarea id= "textAreaEmail" rows ="4" cols ="50"></textarea>
    <br />    
    <asp:Button ID="buttonSend" runat="server" OnClick="buttonSend_Click" Text="Send" />

</asp:Content>
