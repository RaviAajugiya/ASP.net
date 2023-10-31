using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.net_Introduction
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rbnColor_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rbn = (RadioButton)sender;
            LabelDemo.ForeColor = System.Drawing.Color.FromName(rbn.Text);
            //if (rbnBlue.Checked)
            //    LabelDemo.ForeColor = System.Drawing.Color.Blue;
            //else if (rbnGreen.Checked)
            //    LabelDemo.ForeColor = System.Drawing.Color.Green;
            //else
            //    LabelDemo.ForeColor = System.Drawing.Color.Red;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}