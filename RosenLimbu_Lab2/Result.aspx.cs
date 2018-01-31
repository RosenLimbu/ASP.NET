using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*Author: Rosen Limbu
 * Date: January 12, 2018
 * Descrption: This is the second page where I receive the selected dates and count the number of times it has been selected
 * */

namespace RosenLimbu_Lab2
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //disable the textbox so the user is unable to make changes
            txtDay1.Enabled = false;
            txtDay2.Enabled = false;
            txtDay3.Enabled = false;

            txtDay1.Text = Application["first"].ToString();
            txtDay2.Text = Application["second"].ToString();
            txtDay3.Text = Application["third"].ToString();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            //send the response back to the first page - index page
            Response.Redirect("~/Index.aspx");
        }
    }
}