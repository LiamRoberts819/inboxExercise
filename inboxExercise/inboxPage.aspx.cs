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
            }
           
        }

        protected void buttonDeletedEmails_Click(object sender, EventArgs e)
        {
            deletedPage();
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void buttonDelete_Click(object sender, EventArgs e)
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

                        cmd.CommandText = string.Format("update Emails set Deleted='D' where EmailId = '{0}'", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            showData();
        }

        protected void buttonRestore_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox chck = (CheckBox)row.FindControl("checkBoxRestore");
                if (row.RowType == DataControlRowType.DataRow)
                {
                    if (chck.Checked)
                    {
                        int id = Convert.ToInt32(((Label)row.Cells[0].FindControl("Label4")).Text);

                        con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
                        con.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = con;

                        cmd.CommandText = string.Format("update Emails set Deleted='N' where EmailId = '{0}'", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            deletedPage();
        }

        public void showData()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            Session["User"] = "xyz";

            cmd.CommandText = string.Format("select * from Emails where ToUser = '{0}' and Deleted = 'N'", Session["User"]);
            reader = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            GridView1.Columns[1].Visible = true;
            GridView1.Columns[2].Visible = false;
            buttonDelete.Visible = true;
            buttonRestore.Visible = false;

            setBold();
        }

        protected void buttonInbox_Click(object sender, EventArgs e)
        {
            showData();
            setBold();
            GridView1.Columns[1].Visible = true;
            GridView1.Columns[2].Visible = false;
            buttonDelete.Visible = true;
            buttonRestore.Visible = false;
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
            GridView1.Columns[1].Visible = true;
            GridView1.Columns[2].Visible = false;
            buttonDelete.Visible = true;
            buttonRestore.Visible = false;
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

        private void deletedPage()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            Session["User"] = "xyz";

            cmd.CommandText = string.Format("select * from Emails where ToUser = '{0}' and Deleted = 'D'", Session["User"]);
            reader = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.Columns[1].Visible = false;
            GridView1.Columns[2].Visible = true;
            buttonDelete.Visible = false;
            buttonRestore.Visible = true;
        }




        protected void buttonCompose_Click(object sender, EventArgs e)
        {
            Response.Redirect("composePage.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}