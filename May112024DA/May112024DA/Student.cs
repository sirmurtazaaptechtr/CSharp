using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

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

        
    }
}
