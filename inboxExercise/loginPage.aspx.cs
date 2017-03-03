using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace inboxExercise
{
    public partial class loginPage : System.Web.UI.Page
    {
        HtmlGenericControl BG_Body = (HtmlGenericControl)Master.FindControl("BG_Body");
        protected void Page_Load(object sender, EventArgs e)
        {  
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton4.Checked == true)
            {
                Response.Cookies["Colour"].Value = "red";
                if (Request.Cookies["Colour"].Value != "")
                {
                    BG_Body.Style.Add("background-color", Request.Cookies["Colour"].Value);
                }
                //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(2);
                //Response.Write(Request.Cookies["Colour"].Value);
            }
            if (RadioButton2.Checked == true)
            {
                Response.Cookies["Colour"].Value = "blue";
                if (Request.Cookies["Colour"].Value != "")
                {
                    BG_Body.Style.Add("background-color", Request.Cookies["Colour"].Value);
                }
                //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(2);
            }
            if (RadioButton3.Checked == true)
            {
                Response.Cookies["Colour"].Value = "yellow";
                if (Request.Cookies["Colour"].Value != "")
                {
                    BG_Body.Style.Add("background-color", Request.Cookies["Colour"].Value);
                }
                //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(2);
            }
            Response.Redirect("loginForm.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (RadioButton4.Checked == true)
            {
                Response.Cookies["Colour"].Value = "red";
                if (Request.Cookies["Colour"].Value != "")
                {
                    BG_Body.Style.Add("background-color", Request.Cookies["Colour"].Value);
                }
                //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(2);
                //Response.Write(Request.Cookies["Colour"].Value);
            }
            if (RadioButton2.Checked == true)
            {
                Response.Cookies["Colour"].Value = "blue";
                if (Request.Cookies["Colour"].Value != "")
                {
                    BG_Body.Style.Add("background-color", Request.Cookies["Colour"].Value);
                }
                //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(2);
            }
            if (RadioButton3.Checked == true)
            {
                Response.Cookies["Colour"].Value = "yellow";
                if (Request.Cookies["Colour"].Value != "")
                {
                    BG_Body.Style.Add("background-color", Request.Cookies["Colour"].Value);
                }
                //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(2);
            }
            Response.Redirect("createAccount.aspx");
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}