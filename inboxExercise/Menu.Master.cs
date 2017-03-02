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

        string _color;
        protected void Page_init(object sender, EventArgs e)
        {
            color = "blue";                                 //Here the color you want to define either from database or userdefined
        }
        public string color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

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