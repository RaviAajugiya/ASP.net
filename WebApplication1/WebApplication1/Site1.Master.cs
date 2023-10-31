using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        public String labelText
        {
            get
            {
                return Label1.Text;

            }
            set
            {
                Label1.Text = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Load from master";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Click From MAster";
        }
    }
}