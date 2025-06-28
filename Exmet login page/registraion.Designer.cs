namespace Exmet_login_page
{
    partial class registraion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registraion));
            close = new PictureBox();
            btnlogin1 = new Button();
            btnsingup = new Button();
            username = new Label();
            pictureBoxuser = new PictureBox();
            txtUsername = new TextBox();
            password = new Label();
            pictureBoxpass = new PictureBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            labelcpass = new Label();
            pictureBoxcpass = new PictureBox();
            txtEmail = new TextBox();
            lableemail = new Label();
            pictureBoxemail = new PictureBox();
            pictureBoxlogo = new PictureBox();
            checkBoxshowpass = new CheckBox();
            pictureBox2in = new PictureBox();
            buttonsignin = new Button();
            panel1in = new Panel();
            pictureBox1outer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxuser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxcpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxemail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2in).BeginInit();
            panel1in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1outer).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.BackColor = Color.MidnightBlue;
            close.Cursor = Cursors.Hand;
            close.Image = (Image)resources.GetObject("close.Image");
            close.Location = new Point(1245, -1);
            close.Name = "close";
            close.Size = new Size(33, 29);
            close.SizeMode = PictureBoxSizeMode.Zoom;
            close.TabIndex = 14;
            close.TabStop = false;
            close.Click += close_Click;
            // 
            // btnlogin1
            // 
            btnlogin1.BackColor = Color.MidnightBlue;
            btnlogin1.Cursor = Cursors.Hand;
            btnlogin1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin1.ForeColor = SystemColors.ButtonHighlight;
            btnlogin1.ImageAlign = ContentAlignment.TopLeft;
            btnlogin1.Location = new Point(434, 111);
            btnlogin1.Name = "btnlogin1";
            btnlogin1.Size = new Size(140, 38);
            btnlogin1.TabIndex = 17;
            btnlogin1.Text = "Login";
            btnlogin1.UseVisualStyleBackColor = false;
            btnlogin1.Click += btnlogin1_Click;
            // 
            // btnsingup
            // 
            btnsingup.BackColor = SystemColors.ButtonHighlight;
            btnsingup.Cursor = Cursors.Hand;
            btnsingup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsingup.ForeColor = SystemColors.MenuHighlight;
            btnsingup.ImageAlign = ContentAlignment.TopLeft;
            btnsingup.Location = new Point(571, 148);
            btnsingup.Name = "btnsingup";
            btnsingup.Size = new Size(138, 38);
            btnsingup.TabIndex = 20;
            btnsingup.Text = "Singup";
            btnsingup.UseVisualStyleBackColor = false;
            btnsingup.Click += btnsingup_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.Black;
            username.Location = new Point(69, 230);
            username.Name = "username";
            username.Size = new Size(86, 20);
            username.TabIndex = 21;
            username.Text = "Username:";
            // 
            // pictureBoxuser
            // 
            pictureBoxuser.Image = Properties.Resources._852267_user_512x512;
            pictureBoxuser.Location = new Point(40, 231);
            pictureBoxuser.Name = "pictureBoxuser";
            pictureBoxuser.Size = new Size(17, 19);
            pictureBoxuser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxuser.TabIndex = 22;
            pictureBoxuser.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(35, 256);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(340, 27);
            txtUsername.TabIndex = 23;
            txtUsername.TextChanged += txtEmail_TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = Color.Black;
            password.Location = new Point(58, 382);
            password.Name = "password";
            password.Size = new Size(82, 20);
            password.TabIndex = 24;
            password.Text = "Password:";
            // 
            // pictureBoxpass
            // 
            pictureBoxpass.Image = (Image)resources.GetObject("pictureBoxpass.Image");
            pictureBoxpass.Location = new Point(35, 383);
            pictureBoxpass.Name = "pictureBoxpass";
            pictureBoxpass.Size = new Size(17, 19);
            pictureBoxpass.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxpass.TabIndex = 25;
            pictureBoxpass.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(35, 408);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(340, 27);
            txtPassword.TabIndex = 26;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(35, 491);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(340, 27);
            txtConfirmPassword.TabIndex = 27;
            // 
            // labelcpass
            // 
            labelcpass.AutoSize = true;
            labelcpass.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcpass.ForeColor = Color.Black;
            labelcpass.Location = new Point(58, 458);
            labelcpass.Name = "labelcpass";
            labelcpass.Size = new Size(144, 20);
            labelcpass.TabIndex = 28;
            labelcpass.Text = "Confirm Password:";
            // 
            // pictureBoxcpass
            // 
            pictureBoxcpass.Image = (Image)resources.GetObject("pictureBoxcpass.Image");
            pictureBoxcpass.Location = new Point(35, 459);
            pictureBoxcpass.Name = "pictureBoxcpass";
            pictureBoxcpass.Size = new Size(17, 19);
            pictureBoxcpass.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxcpass.TabIndex = 29;
            pictureBoxcpass.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 330);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 27);
            txtEmail.TabIndex = 30;
            // 
            // lableemail
            // 
            lableemail.AutoSize = true;
            lableemail.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lableemail.ForeColor = Color.Black;
            lableemail.Location = new Point(69, 304);
            lableemail.Name = "lableemail";
            lableemail.Size = new Size(51, 20);
            lableemail.TabIndex = 31;
            lableemail.Text = "Email:";
            // 
            // pictureBoxemail
            // 
            pictureBoxemail.Image = (Image)resources.GetObject("pictureBoxemail.Image");
            pictureBoxemail.Location = new Point(35, 304);
            pictureBoxemail.Name = "pictureBoxemail";
            pictureBoxemail.Size = new Size(22, 20);
            pictureBoxemail.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxemail.TabIndex = 32;
            pictureBoxemail.TabStop = false;
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.Image = (Image)resources.GetObject("pictureBoxlogo.Image");
            pictureBoxlogo.Location = new Point(133, 70);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(117, 116);
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxlogo.TabIndex = 33;
            pictureBoxlogo.TabStop = false;
            // 
            // checkBoxshowpass
            // 
            checkBoxshowpass.AutoSize = true;
            checkBoxshowpass.Location = new Point(243, 522);
            checkBoxshowpass.Name = "checkBoxshowpass";
            checkBoxshowpass.Size = new Size(132, 24);
            checkBoxshowpass.TabIndex = 35;
            checkBoxshowpass.Text = "Show Password";
            checkBoxshowpass.UseVisualStyleBackColor = true;
            // 
            // pictureBox2in
            // 
            pictureBox2in.Image = Properties.Resources.WhatsApp_Image_2025_06_27_at_15_23_55_790459e3;
            pictureBox2in.Location = new Point(573, -3);
            pictureBox2in.Name = "pictureBox2in";
            pictureBox2in.Size = new Size(515, 623);
            pictureBox2in.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2in.TabIndex = 0;
            pictureBox2in.TabStop = false;
            // 
            // buttonsignin
            // 
            buttonsignin.BackColor = Color.MidnightBlue;
            buttonsignin.Cursor = Cursors.Hand;
            buttonsignin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonsignin.ForeColor = SystemColors.ButtonHighlight;
            buttonsignin.Location = new Point(35, 552);
            buttonsignin.Name = "buttonsignin";
            buttonsignin.Size = new Size(340, 44);
            buttonsignin.TabIndex = 34;
            buttonsignin.Text = "Sign in";
            buttonsignin.UseVisualStyleBackColor = false;
            buttonsignin.Click += buttonsignin_Click;
            // 
            // panel1in
            // 
            panel1in.BackColor = SystemColors.ButtonHighlight;
            panel1in.Controls.Add(checkBoxshowpass);
            panel1in.Controls.Add(buttonsignin);
            panel1in.Controls.Add(pictureBoxlogo);
            panel1in.Controls.Add(pictureBoxemail);
            panel1in.Controls.Add(lableemail);
            panel1in.Controls.Add(txtEmail);
            panel1in.Controls.Add(pictureBoxcpass);
            panel1in.Controls.Add(labelcpass);
            panel1in.Controls.Add(txtConfirmPassword);
            panel1in.Controls.Add(txtPassword);
            panel1in.Controls.Add(pictureBoxpass);
            panel1in.Controls.Add(password);
            panel1in.Controls.Add(txtUsername);
            panel1in.Controls.Add(pictureBoxuser);
            panel1in.Controls.Add(username);
            panel1in.Controls.Add(btnsingup);
            panel1in.Controls.Add(btnlogin1);
            panel1in.Controls.Add(pictureBox2in);
            panel1in.Location = new Point(66, 77);
            panel1in.Name = "panel1in";
            panel1in.Size = new Size(1086, 620);
            panel1in.TabIndex = 1;
            // 
            // pictureBox1outer
            // 
            pictureBox1outer.Image = Properties.Resources.WhatsApp_Image_2025_06_27_at_15_23_55_790459e3;
            pictureBox1outer.Location = new Point(639, -1);
            pictureBox1outer.Name = "pictureBox1outer";
            pictureBox1outer.Size = new Size(639, 769);
            pictureBox1outer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1outer.TabIndex = 0;
            pictureBox1outer.TabStop = false;
            // 
            // registraion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1278, 768);
            Controls.Add(close);
            Controls.Add(panel1in);
            Controls.Add(pictureBox1outer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registraion";
            Text = "registraion";
            Load += registraion_Load;
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxuser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxcpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxemail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2in).EndInit();
            panel1in.ResumeLayout(false);
            panel1in.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1outer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox close;
        private Button btnlogin1;
        private Button btnsingup;
        private Label username;
        private PictureBox pictureBoxuser;
        private TextBox txtUsername;
        private Label password;
        private PictureBox pictureBoxpass;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label labelcpass;
        private PictureBox pictureBoxcpass;
        private TextBox txtEmail;
        private Label lableemail;
        private PictureBox pictureBoxemail;
        private PictureBox pictureBoxlogo;
        private CheckBox checkBoxshowpass;
        private PictureBox pictureBox2in;
        private Button buttonsignin;
        private Panel panel1in;
        private PictureBox pictureBox1outer;
    }
}