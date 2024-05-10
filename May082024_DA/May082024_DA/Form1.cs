using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace May082024_DA
{
    public partial class Teachers : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        int key = 0;

        public Teachers()
        {
            InitializeComponent();
        }

        private void IDtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addresstb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salarytb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_dbDataSet.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.school_dbDataSet.teacher);
            conn = new SqlConnection(@"Data Source=FACULTY1C\MSSQLSERVER1122;Initial Catalog=school_db;Persist Security Info=True;User ID=sa;Password=123");
            cmd = new SqlCommand();
            cmd.Connection = conn;
            displaydata();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            string InsertQuery = $"insert into teacher(Name,Address,Salary)Values('{Nametb.Text.ToString()}','{Addresstb.Text.ToString()}','{Salarytb.Text.ToString()}')";
            cmd.CommandText = InsertQuery ;
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Record Inserted!");
            conn.Close();
            displaydata();
            cleardata();
        }
        private void cleardata()
        {
            IDtb.Clear();
            Nametb.Clear();
            Addresstb.Clear();
            Salarytb.Clear();
            conn.Close();

        }
        private void displaydata ()
        {
            conn.Open();
            string SelectQuery = $"SELECT * FROM teacher";
            cmd.CommandText = SelectQuery ;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Teachersgv.DataSource = dt;
            conn.Close();
        }

        private void Teachersgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Teachersgv.Rows.Count)
            {
                DataGridViewRow row = Teachersgv.Rows[e.RowIndex];
                IDtb.Text = row.Cells[0].Value.ToString();
                Nametb.Text = row.Cells[1].Value.ToString();
                Addresstb.Text = row.Cells[2].Value.ToString();
                Salarytb.Text = row.Cells[3].Value.ToString();
                key = Convert.ToInt32(row.Cells[0].Value);
                MessageBox.Show("Teacher with ID: " + key.ToString() + " Selected");
            }

        }

        private void Showallbtn_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string UpdateQuery = $"update teacher set Name = '{Nametb.Text.ToString()}',Address = '{Addresstb.Text.ToString()}',salary = '{Salarytb.Text.ToString()}' where id = '{IDtb.Text.ToString()}'";
            cmd.CommandText = UpdateQuery;
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated!");
            conn.Close();
            displaydata();
            cleardata();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string DeleteQuery = $"delete from teacher where id = {IDtb.Text.ToString()}";
            cmd.CommandText = DeleteQuery;
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted!");
            conn.Close();
            displaydata();
            cleardata();
        }
    }
}
