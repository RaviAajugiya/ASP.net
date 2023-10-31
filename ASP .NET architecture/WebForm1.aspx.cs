using ASP.NET_architecture.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_architecture
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //this is not right place to initialize property because it eill be overidden by 
        //postback of form values to be submitted
        protected void Page_Init(object sender, EventArgs e)
        {
            TextBox1.Text = "init";


        }

        //postback
        //1.on form submit the value submited by use will be used to initialize property  
        //  handled internally
        //2.hidden field is used for initializing all the properties of the control


        //right place to init variable
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextBox1.Text = "load";
            Response.Write(Class1.Greetings());

        }

        //post back
        //all control event executed between page_load and pre render
        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = "Click";
            TextBox1.ForeColor = System.Drawing.Color.Red;
        }


        protected void Page_PreRender(object sender, EventArgs e)
        {
            //TextBox1.Text = "pre_render";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //(All modified properties of the control are added to the viewstate(hidden field)
        //rendered to browser)

    }
}