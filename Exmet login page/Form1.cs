using System.Data.SqlClient;
using System.Linq;                             // For LINQ queries like FirstOrDefault
using Microsoft.EntityFrameworkCore;           // For DbContext
using BCrypt.Net;                              // For password hashing

namespace Exmet_login_page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection("Server=JAYKISHAN-PC\\MSSQLSERVER01;Database=users;Integrated Security=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                MessageBox.Show("Connection Successful!");
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoximage_Click(object sender, EventArgs e)
        {

        }

        private void buttoncreateacc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both email/username and password.", "Warning");
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var user = context.Users
                        .Where(u =>
                            !string.IsNullOrEmpty(u.Email) &&
                            !string.IsNullOrEmpty(u.Username) &&
                            !string.IsNullOrEmpty(u.PasswordHash))
                        .FirstOrDefault(u =>
                            u.Email == txtEmail.Text || u.Username == txtEmail.Text);

                    if (user != null && user.PasswordHash == txtPassword.Text)
                    {
                        MessageBox.Show("Login Successful!");
                        // Open dashboard or next form
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsingup_Click(object sender, EventArgs e)
        {
            registraion registraion = new registraion();
            registraion.Show();
            this.Hide();
        }

        private void btnlogin1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in Login Page:-");

        }
    }
}
