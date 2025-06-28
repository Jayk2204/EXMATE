namespace Exmet_login_page
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnsingup = new Button();
            checkBox1 = new CheckBox();
            btnlogin = new Button();
            btnlogin1 = new Button();
            txtPassword = new TextBox();
            password = new Label();
            pictureBox2 = new PictureBox();
            txtEmail = new TextBox();
            pictureBoxuser = new PictureBox();
            username = new Label();
            pictureBoxlogo = new PictureBox();
            pictureBoximg2 = new PictureBox();
            close = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxuser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoximg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_06_27_at_15_23_55_790459e3;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(522, 769);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnsingup);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(btnlogin1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(password);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(pictureBoxuser);
            panel1.Controls.Add(username);
            panel1.Controls.Add(pictureBoxlogo);
            panel1.Controls.Add(pictureBoximg2);
            panel1.Location = new Point(66, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 620);
            panel1.TabIndex = 1;
            // 
            // btnsingup
            // 
            btnsingup.BackColor = Color.MidnightBlue;
            btnsingup.Cursor = Cursors.Hand;
            btnsingup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsingup.ForeColor = SystemColors.ButtonHighlight;
            btnsingup.ImageAlign = ContentAlignment.TopLeft;
            btnsingup.Location = new Point(454, 293);
            btnsingup.Name = "btnsingup";
            btnsingup.Size = new Size(138, 38);
            btnsingup.TabIndex = 19;
            btnsingup.Text = "Singup";
            btnsingup.UseVisualStyleBackColor = false;
            btnsingup.Click += btnsingup_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(855, 420);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.MidnightBlue;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.ButtonHighlight;
            btnlogin.Location = new Point(647, 471);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(340, 40);
            btnlogin.TabIndex = 17;
            btnlogin.Text = "Get Started";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += buttoncreateacc_Click;
            // 
            // btnlogin1
            // 
            btnlogin1.BackColor = SystemColors.ButtonHighlight;
            btnlogin1.Cursor = Cursors.Hand;
            btnlogin1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin1.ForeColor = Color.Blue;
            btnlogin1.ImageAlign = ContentAlignment.TopLeft;
            btnlogin1.Location = new Point(318, 261);
            btnlogin1.Name = "btnlogin1";
            btnlogin1.Size = new Size(136, 33);
            btnlogin1.TabIndex = 16;
            btnlogin1.Text = "Login";
            btnlogin1.UseVisualStyleBackColor = false;
            btnlogin1.Click += btnlogin1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(647, 377);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(340, 27);
            txtPassword.TabIndex = 15;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = Color.Black;
            password.Location = new Point(665, 354);
            password.Name = "password";
            password.Size = new Size(82, 20);
            password.TabIndex = 14;
            password.Text = "Password:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(647, 355);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(647, 293);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 27);
            txtEmail.TabIndex = 12;
            // 
            // pictureBoxuser
            // 
            pictureBoxuser.Image = Properties.Resources._852267_user_512x512;
            pictureBoxuser.Location = new Point(647, 268);
            pictureBoxuser.Name = "pictureBoxuser";
            pictureBoxuser.Size = new Size(17, 19);
            pictureBoxuser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxuser.TabIndex = 11;
            pictureBoxuser.TabStop = false;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.Black;
            username.Location = new Point(661, 267);
            username.Name = "username";
            username.Size = new Size(86, 20);
            username.TabIndex = 5;
            username.Text = "Username:";
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.Image = (Image)resources.GetObject("pictureBoxlogo.Image");
            pictureBoxlogo.Location = new Point(759, 106);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(117, 116);
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxlogo.TabIndex = 1;
            pictureBoxlogo.TabStop = false;
            // 
            // pictureBoximg2
            // 
            pictureBoximg2.Image = Properties.Resources.WhatsApp_Image_2025_06_27_at_15_23_55_790459e3;
            pictureBoximg2.Location = new Point(0, 0);
            pictureBoximg2.Name = "pictureBoximg2";
            pictureBoximg2.Size = new Size(454, 620);
            pictureBoximg2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoximg2.TabIndex = 0;
            pictureBoximg2.TabStop = false;
            // 
            // close
            // 
            close.BackColor = SystemColors.ButtonHighlight;
            close.Cursor = Cursors.Hand;
            close.Image = (Image)resources.GetObject("close.Image");
            close.Location = new Point(1246, -1);
            close.Name = "close";
            close.Size = new Size(33, 29);
            close.SizeMode = PictureBoxSizeMode.Zoom;
            close.TabIndex = 13;
            close.TabStop = false;
            close.Click += close_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1278, 768);
            Controls.Add(close);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "exmetlogin";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxuser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoximg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBoximg2;
        private PictureBox pictureBoxlogo;
        private Label username;
        private PictureBox pictureBoxuser;
        private TextBox txtEmail;
        private PictureBox pictureBox2;
        private Label password;
        private TextBox txtPassword;
        private Button btnlogin1;
        private Button btnlogin;
        private CheckBox checkBox1;
        private Button btnsingup;
        private PictureBox close;
    }
}
