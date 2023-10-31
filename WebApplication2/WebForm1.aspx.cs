using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=.; database=Students; integrated security=SSPI");
            //SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Student", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();


            //DataTable table = new DataTable();
            //table.Columns.Add("ID");
            //table.Columns.Add("Name");
            //table.Columns.Add("Email");
            //table.Rows.Add("101", "Rameez", "rameez@example.com");
            //table.Rows.Add("102", "Sam Nicolus", "sam@example.com");
            //table.Rows.Add("103", "Subramanium", "subramanium@example.com");
            //table.Rows.Add("104", "Ankur Kumar", "ankur@example.com");
            //GridView1.DataSource = table;
            //GridView1.DataBind();

        }
    }
}