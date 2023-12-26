using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dec232023
{
    public partial class Form1 : Form
    {
        private readonly string ConnectionString = @"Data Source=FACULTY1C\MSSQLSERVER1122;Initial Catalog=school;Persist Security Info=True;User ID=sa;Password=123";

        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayTeachers();
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameLbl_Click(object sender, EventArgs e)
        {

        }

        private void AddressLbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalaryLbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string findSql = "SELECT * FROM teachers WHERE id = @Id OR name LIKE @Name + '%'";

                using (SqlCommand command = new SqlCommand(findSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", IdTb.Text);
                    command.Parameters.AddWithValue("@Name", NameTb.Text);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);

                    TeachersDGV.DataSource = dt;
                }
            }
        }


        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string insertSql = "INSERT INTO teachers (name, address, salary) VALUES (@Name, @Address, @Salary)";
                    using (SqlCommand command = new SqlCommand(insertSql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", NameTb.Text);
                        command.Parameters.AddWithValue("@Address", AddressTb.Text);
                        command.Parameters.AddWithValue("@Salary", SalaryTb.Text);

                        command.ExecuteNonQuery();
                    }
                }

                ClearData();
                DisplayTeachers();
            }
        }
        

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string updateSql = "UPDATE teachers SET name = @Name, address = @Address, salary = @Salary WHERE id = @Id";
                    using (SqlCommand command = new SqlCommand(updateSql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", NameTb.Text);
                        command.Parameters.AddWithValue("@Address", AddressTb.Text);
                        command.Parameters.AddWithValue("@Salary", SalaryTb.Text);
                        command.Parameters.AddWithValue("@Id", IdTb.Text);

                        command.ExecuteNonQuery();
                    }
                }

                ClearData();
                DisplayTeachers();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteTeacher();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ShowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayTeachers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IdTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void DeleteTeacher()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string deletesql = "DELETE FROM teachers WHERE id = @Id";

                using (SqlCommand command = new SqlCommand(deletesql, connection))
                {
                    command.Parameters.AddWithValue("@Id", IdTb.Text);
                    command.ExecuteNonQuery();
                }
            }

            // If the deletion is successful, clear data and refresh the display
            ClearData();
            DisplayTeachers();
        }
        private void DisplayTeachers()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM teachers";

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }

                    TeachersDGV.DataSource = dt;
                }
            }
        }
        private void ClearData()
        {
            IdTb.Clear();
            NameTb.Clear();
            AddressTb.Clear();
            SalaryTb.Clear();
        }
        private bool ValidateInput()
        {
            // Implement input validation logic
            // Return true if input is valid, false otherwise
            return true;
        }

        
    }
}
