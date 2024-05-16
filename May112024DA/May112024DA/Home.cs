using System;
using System.Windows.Forms;

namespace May112024DA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void GTHomeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }
        private void StudentsBtn_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();

        }

        private void GTStudentsBtn_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {

        }

        
    }
}
