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
    public partial class viewEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonReply_Click(object sender, EventArgs e)
        {
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
                Session["replyEmail"] = reader["FromUser"];
                Session["replySubject"] = reader["Subject"];
            }
            Session["replyBody"] = Request.Form["textAreaBody"].ToString();
            Response.Redirect("composePage.aspx");
        }

        protected void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = (string.Format("update Emails set status = 'D' where EmailId = '{0}'", Request["emailId"]));
            cmd.ExecuteNonQuery();
            Response.Redirect("inboxPage.aspx");

        }
    }
}