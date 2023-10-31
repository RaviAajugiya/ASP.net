using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Redirect
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //public String txtData;

        public String txtData {
            get { return TextBox1.Text; }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            //txtData = TextBox1.Text;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            String value = TextBox1.Text;
            Response.Redirect("Target.aspx?txt=" + value);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Context.Items["txt"] = TextBox1.Text;
            Server.Transfer("Target.aspx");
        }

    }
}