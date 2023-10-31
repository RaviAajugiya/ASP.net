using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            //Label lbl = (Label)Master.FindControl("Label1");
            //lbl.Text = "Load from 1";

            Master.labelText = "Load from 1";
        }
    }
}