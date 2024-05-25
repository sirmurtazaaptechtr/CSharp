using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace May112024DA
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection Conn;
        SqlCommand Cmd;
        int key = -1;

        string cs = @"Data Source=FACULTY1C\MSSQLSERVER1122;Initial Catalog=school_db;Persist Security Info=True;User ID=sa;Password=123";

        private void Student_Load(object sender, EventArgs e)
        {
            Conn = new SqlConnection(cs);
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
        }

        private void StudentsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            displaydata();            
        }
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Student values ('{NameTb.Text.ToString()}','{EmailTb.Text.ToString()}','{dobDTP.Value.ToString()}','{ContactTb.Text.ToString()}')";
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = query;
            try
            {
                Conn.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            MessageBox.Show("Record Inserted Successfully");
            cleardata();
            displaydata();
        }

        private void displaydata()
        {
            string query = $"SELECT * FROM Student";
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = query;
            try
            {
                Conn.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }

            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StudentsGV.DataSource = dt;            
        }
        private void cleardata()
        {
            IdTb.Clear();
            NameTb.Clear();
            EmailTb.Clear();
            ContactTb.Clear();
        }

        private void AddNewStdGB_Enter(object sender, EventArgs e)
        {

        }

        private void StudentsGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < StudentsGV.Rows.Count)
            {
                DataGridViewRow row = StudentsGV.Rows[e.RowIndex];
                IdTb.Text = row.Cells[0].Value.ToString();
                NameTb.Text = row.Cells[1].Value.ToString();
                EmailTb.Text = row.Cells[2].Value.ToString();
                dobDTP.Text = row.Cells[3].Value.ToString();
                ContactTb.Text = row.Cells[4].Value.ToString();
                key = Convert.ToInt32(IdTb.Text);

                //MessageBox.Show($"{key},{NameTb.Text},{EmailTb.Text}, {dobDTP.Text} and {ContactTb.Text} is selected");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE Student SET name = '{NameTb.Text.ToString()}', email = '{EmailTb.Text.ToString()}',dob = '{dobDTP.Value.ToString()}',contact = '{ContactTb.Text.ToString()}' WHERE id = '{key}'";
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = query;
            try
            {
                Conn.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            MessageBox.Show("Record Updated Successfully");
            cleardata();
            displaydata();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(key >= 0)
            {
                string query = $"DELETE FROM Student WHERE id = '{key}'";
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = query;
                try
                {
                    Conn.Open();
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }
                MessageBox.Show("Record Updated Successfully");
                cleardata();
                displaydata();


            }
        }
    }
}
