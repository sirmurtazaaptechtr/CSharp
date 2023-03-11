using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebApp_6Apr2022_1
{
    public partial class About : Page
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