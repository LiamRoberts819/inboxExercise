using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace inboxExercise
{
    public partial class loginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Colour"].Value != "")
 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginForm.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("createAccount.aspx");
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Response.Cookies["Colour"].Value = "yellow";
            //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(1);
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Response.Cookies["Colour"].Value = "blue";
            //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(1);
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Response.Cookies["Colour"].Value = "red";
            //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(1);
            //Response.Write(Request.Cookies["Colour"].Value);
            //Response.Write("Test");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (RadioButton4.Checked == true)
            {
                Response.Cookies["Colour"].Value = "red";
                //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(2);
                //Response.Write(Request.Cookies["Colour"].Value);
            }
            if (RadioButton2.Checked == true)
            {
                Response.Cookies["Colour"].Value = "blue";
                //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(2);
            }
            if (RadioButton3.Checked == true)
            {
                Response.Cookies["Colour"].Value = "yellow";
                //Response.Cookies["Colour"].Expires = DateTime.Now.AddDays(2);
            }
        }
    }
}