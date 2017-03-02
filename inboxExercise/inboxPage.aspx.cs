using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace inboxExercise
{
    public partial class inboxPage : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        DataTable dt;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            Session["User"] = "xyz";

            cmd.CommandText = string.Format("select * from Emails where ToUser = '{0}' and Status <> 'D'", Session["User"]);
            reader = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }

        protected void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        protected void buttonDeletedEmails_Click(object sender, EventArgs e)
        {
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void buttonDelete_Click1(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (((CheckBox)row.FindControl("checkBoxDelete")).Checked)
                {                    
                    Response.Write(row.Cells[2].Text);
                }
            }
        }


    }
}