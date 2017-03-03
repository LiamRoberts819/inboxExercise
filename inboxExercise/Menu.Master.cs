using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace inboxExercise
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.Cookies["Colour"].Value != "")
                {
                    Menu_Body.Style.Add("background-color", Request.Cookies["Colour"].Value);
                }
            }
            catch (Exception ex) { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("inboxPage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("loginPage.aspx");
        }
    }
}