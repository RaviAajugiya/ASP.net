using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_Page
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            MasterLabel.Text = "Page load of master";
            //Response.Write(" master page load ");

        }

        protected void MasterBtn_Click(object sender, EventArgs e)
        {
            MasterLabel.Text = "This is button click from master";
        }

    }
}