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
        TextBox TextBoxOldPass = new TextBox();
        TextBox TextBoxNewPass = new TextBox();
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
                    this.TextBoxOldPass.Visible = true;
                    this.TextBoxNewPass.Visible = true;
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
            cmd.CommandText = "Select * from Users where EmailAddress = '" + TextBox1.Text + "'";
            R = cmd.ExecuteReader();
            if (R.Read())
            {
                string UserInfo = R["Password"].ToString();
                if (TextBoxOldPass.Text == UserInfo)
                {
                    Response.Write(TextBoxNewPass.Text);
                    R.Close();
                    cmd.CommandText = "Update Customers Set Password = '" + TextBoxNewPass + "' where EmailAddress = '" + TextBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                  
                }
                else Response.Write("Old Password is Wrong");
            }
        }
    }
}