using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.net_Introduction
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox1.Text = "Ravi";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Literal1.Text = "Hello " + TextBox1.Text;
        }
    }
}