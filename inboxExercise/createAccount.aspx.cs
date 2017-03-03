using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace inboxExercise
{
    public partial class WebForm1 : System.Web.UI.Page
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
            if (TextBox4.Text == TextBox5.Text)
            {
                cmd.CommandText = "Insert into Users Values ('" + TextBox3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')";
                cmd.ExecuteNonQuery();
                Response.Redirect("inboxPage.aspx");
            }
            else Response.Write("Passwords do not match");
        }
    }
}