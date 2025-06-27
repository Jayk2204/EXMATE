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
            using (var context = new ApplicationDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == txtEmail.Text || u.Username == txtEmail.Text);

                if (user != null && user.PasswordHash == txtPassword.Text)

                {
                    MessageBox.Show("Login Successful!");
                    // Open Dashboard or Next Form
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
        }
    }
}
