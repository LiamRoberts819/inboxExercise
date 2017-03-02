using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace inboxExercise
{
    public partial class composePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonSend_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = string.Format("insert into Emails values ('{0}','{1}','{2}','{3}'", FromUser, ToUser, Subject, Text);

        }
    }
}