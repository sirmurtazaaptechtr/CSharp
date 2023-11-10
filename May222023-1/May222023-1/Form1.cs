using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace May222023_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source = LAB1A\MSSQLSERVER1122; database=Northwind; integrated security=SSPI");
            SqlCommand cmd = new SqlCommand("select * from customers", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = dr;
            dataGridView1.DataSource = source;
            con.Close(); 
        }
    }
}
