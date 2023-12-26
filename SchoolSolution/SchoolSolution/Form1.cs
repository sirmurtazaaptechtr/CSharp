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

namespace SchoolSolution
{
    public partial class TeachersForm : Form
    {
        public TeachersForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlCommand cmd = null;

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=FACULTY1C\MSSQLSERVER1122;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=123");

        }
    }
}
