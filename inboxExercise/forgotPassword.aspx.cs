using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace inboxExercise
{
    public partial class forgotPassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Source\\Repos\\inboxExercise\\inboxExercise\\App_Data\\Database1.mdf';Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataReader R;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Users where EmailAddress = '" + TextBox1.Text + "'";
            R = cmd.ExecuteReader();
            if (R.Read())
            {
                if (TextBox2.Text == R["SecurityAnswer"].ToString())
                {
                    TextBox3.Visible = true;
                    TextBox4.Visible = true;
                    TextBox1.ReadOnly = true;
                    TextBox2.ReadOnly = true;
                    Button2.Enabled = true;
                }
                else Response.Write("Invalid Security Answer");
            }
            else Response.Write("Invalid E-mail Address");
            R.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Response.Write("->>" + TextBox3.Text);
            con.Open();
            cmd.Connection = con;
            if (TextBox3.Text == TextBox4.Text)
            {
                cmd.CommandText = "Update Users Set Password = '" + TextBox3.Text + "' where EmailAddress = '" + TextBox1.Text + "'";
                cmd.ExecuteNonQuery();
                Response.Redirect("loginForm.aspx");
            }
            else Response.Write("Password's dont match");
        }

        protected void TextBoxNewConfirm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
