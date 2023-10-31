using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Redirect
{
    public partial class Target : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage == null)
            {
                //Gives eroor
                //TextBox tb = (TextBox)PreviousPage.FindControl("TextBox1");
                //Response.Write(tb.Text + " Redirect/Hyperlink");

                Response.Write(Request.QueryString["txt"] + " Redirect/Hyperlink");
            }
            else if(PreviousPage.IsCrossPagePostBack)
            {
                TextBox tb = (TextBox)PreviousPage.FindControl("TextBox1");
                Response.Write(tb.Text + " Cross page Transfer");



                //Response.Write(Request.Form["TextBox1"] + " Cross page Transfer");
            }
            else
            {
                //TextBox tb = (TextBox)PreviousPage.FindControl("TextBox1");
                //Response.Write(tb.Text + " server Transfer");

                String value = PreviousPage.txtData;
                Response.Write(value + " server Transfer");

                //Response.Write(Context.Items["txt"] + " server Transfer");

            }
        }
    }
}