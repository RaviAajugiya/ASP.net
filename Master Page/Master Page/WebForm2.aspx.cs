using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_Page
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Label lbl = (Label)Master.FindControl("MasterLabel");
            lbl.Text = "Load from 2";
        }


    }
}