using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace May112024DA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Conn;
        SqlCommand Cmd;

        string cs = @"Data Source=FACULTY1C\MSSQLSERVER1122;Initial Catalog=school_db;Persist Security Info=True;User ID=sa;Password=123";

        private void Login_Load(object sender, EventArgs e)
        {
            Conn = new SqlConnection(cs);
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information (Username or Password)!");
            }
            else
            {
                string EnteredUserName = UserNameTb.Text.Trim();
                string EnteredPassword = PasswordTb.Text.Trim();
                
                string SelectSQL = $"SELECT password FROM login WHERE username = '{EnteredUserName}'";

                Cmd.CommandText = SelectSQL;

                object PasswordFromDBObj = "";
                
                try
                {
                    Conn.Open();
                    PasswordFromDBObj = Cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }

                if (PasswordFromDBObj != null )
                {
                    string PasswordFromDB = PasswordFromDBObj.ToString().Trim();

                    if(EnteredPassword == PasswordFromDB)
                    {
                        MessageBox.Show("Login successful");
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password!");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Username!");
                }

            }
            
        }
    }
}
