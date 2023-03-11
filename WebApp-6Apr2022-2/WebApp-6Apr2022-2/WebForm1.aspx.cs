using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApp_6Apr2022_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ConString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection Con = new SqlConnection(ConString);
            SqlCommand Cmd = new SqlCommand("select * from Customers", Con);
            Con.Open();
            GridView1.DataSource = Cmd.ExecuteReader();
            GridView1.DataBind();
        }
    }
}