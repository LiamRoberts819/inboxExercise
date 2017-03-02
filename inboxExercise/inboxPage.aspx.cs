using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace inboxExercise
{
    public partial class inboxPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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