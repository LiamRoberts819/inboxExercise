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
            if (!IsPostBack)
            {
                showData();
                setBold();
            }
           
        }

        protected void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        protected void buttonDeletedEmails_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            Session["User"] = "xyz";

            cmd.CommandText = string.Format("select * from Emails where ToUser = '{0}' and Status = 'D'", Session["User"]);
            reader = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void buttonDelete_Click1(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox chck = (CheckBox)row.FindControl("checkBoxDelete");
                if (row.RowType == DataControlRowType.DataRow)
                {
                    if (chck.Checked)
                    {
                        int id = Convert.ToInt32(((Label)row.Cells[0].FindControl("Label4")).Text);

                        con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
                        con.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = con;

                        cmd.CommandText = string.Format("update Emails set Status='D' where EmailId = '{0}'", id);
                        Response.Write(cmd.CommandText);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            showData();
        }

        public void showData()
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

        protected void buttonInbox_Click(object sender, EventArgs e)
        {
            showData();
            setBold();
        }

        protected void buttonSent_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            Session["User"] = "xyz";

            cmd.CommandText = string.Format("select * from Emails where FromUser = '{0}'", Session["User"]);
            reader = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        public void setBold()
        {
            string status;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;        


            foreach (GridViewRow row in GridView1.Rows)
            {
                int id = Convert.ToInt32(((Label)row.Cells[0].FindControl("Label4")).Text);
                cmd.CommandText = string.Format("select Status from Emails where EmailId = '{0}'", id);
                status = cmd.ExecuteScalar().ToString();

                if (status == "U")
                {
                    row.Style.Add(HtmlTextWriterStyle.FontWeight, "Bold");
                }
            }
        }
    }
}