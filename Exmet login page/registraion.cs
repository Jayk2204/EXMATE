using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exmet_login_page
{
    public partial class registraion : Form
    {
        public registraion()
        {
            InitializeComponent();
        }

        private void registraion_Load(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsignin_Click(object sender, EventArgs e)
        {

            {
                // Step 1: Check if any field is empty
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Step 2: Check if passwords match
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var context = new ApplicationDbContext())
                {
                    // Step 3: Check if username or email already exists
                    var existingUser = context.Users.FirstOrDefault(u =>
                        u.Username == txtUsername.Text || u.Email == txtEmail.Text);

                    if (existingUser != null)
                    {
                        MessageBox.Show("Username or Email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Step 4: Create new user
                    var user = new User
                    {
                        Username = txtUsername.Text,
                        Email = txtEmail.Text,
                        PasswordHash = txtPassword.Text,
                        CreatedAt = DateTime.Now
                    };

                    context.Users.Add(user);
                    context.SaveChanges();

                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // or redirect to login form
                }
            }
        }

        private void btnlogin1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btnsingup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in Signup Page:-");
        }
    }
}
