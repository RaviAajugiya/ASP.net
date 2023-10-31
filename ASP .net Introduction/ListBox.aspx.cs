using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.net_Introduction
{
    public partial class ListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                for (int i = 0; i < 5; i++)
                {
                    ListItem item = new ListItem();
                    item.Text = "Item " + i.ToString();
                    item.Value = i.ToString();
                    ListBox1.Items.Add(item);
                }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ListItem li = ListBox1.SelectedItem;
            ListBox1.Items.Remove(li);
            ListBox2.Items.Add(li);
            li.Selected = false;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            ListItem li = ListBox2.SelectedItem;
            ListBox2.Items.Remove(li);
            ListBox1.Items.Add(li);
            li.Selected = false;
        }

    }
}

