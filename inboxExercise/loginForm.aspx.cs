using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace inboxExercise
{
	public partial class homePage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Source\\Repos\\inboxExercise\\inboxExercise\\App_Data\\Database1.mdf';Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader R;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = cmd.CommandText = "Select * from Users where emailaddress = '" + TextBox1.Text + "' and Password = '" + TextBox2.Text + "'";
            R = cmd.ExecuteReader();
            if (R.Read())
            {
                Session["User"] = R["EmailAddress"].ToString();
                if (CheckBox1.Checked == true)
                {
                    Response.Cookies[R["EmailAddress"].ToString()].Value = TextBox1.Text;
                    Response.Cookies[R["Password"].ToString()].Value = TextBox2.Text;
                    Response.Cookies[R["EmailAddress"].ToString()].Expires = DateTime.Now.AddDays(15);
                    Response.Cookies[R["Password"].ToString()].Expires = DateTime.Now.AddDays(15);
                    Response.Redirect("inboxPage.aspx");
                }

                else
                {
                    Response.Cookies[R["EmailAddress"].ToString()].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies[R["Password"].ToString()].Expires = DateTime.Now.AddDays(-1);
                }
            }
            else
            {
                Response.Write("Invalid Username and Password");
            }    
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}