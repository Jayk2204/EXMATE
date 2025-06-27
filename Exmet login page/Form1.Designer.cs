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
            background = new PictureBox();
            signin = new Label();
            close = new PictureBox();
            logo = new PictureBox();
            username = new Label();
            tbname = new TextBox();
            password = new Label();
            tbpassword = new TextBox();
            checkBox1 = new CheckBox();
            btnlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // background
            // 
            background.Image = Properties.Resources.Financial_analyst_or_consultant_online_Graphics_73723642_1;
            background.Location = new Point(331, 52);
            background.Name = "background";
            background.Size = new Size(944, 671);
            background.SizeMode = PictureBoxSizeMode.Zoom;
            background.TabIndex = 0;
            background.TabStop = false;
            background.Click += pictureBox1_Click;
            // 
            // signin
            // 
            signin.AutoSize = true;
            signin.BackColor = SystemColors.ButtonHighlight;
            signin.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signin.ForeColor = SystemColors.ActiveCaptionText;
            signin.Location = new Point(50, 52);
            signin.Name = "signin";
            signin.Size = new Size(108, 32);
            signin.TabIndex = 1;
            signin.Text = "Sign in";
            signin.Click += label1_Click;
            // 
            // close
            // 
            close.Cursor = Cursors.Hand;
            close.Image = Properties.Resources.close_icon_30;
            close.Location = new Point(1225, 12);
            close.Name = "close";
            close.Size = new Size(38, 34);
            close.SizeMode = PictureBoxSizeMode.Zoom;
            close.TabIndex = 2;
            close.TabStop = false;
            close.Click += close_Click;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.fbgbi04j;
            logo.Location = new Point(139, 130);
            logo.Name = "logo";
            logo.Size = new Size(75, 76);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.Black;
            username.Location = new Point(50, 261);
            username.Name = "username";
            username.Size = new Size(86, 20);
            username.TabIndex = 4;
            username.Text = "Username:";
            // 
            // tbname
            // 
            tbname.Location = new Point(50, 303);
            tbname.Name = "tbname";
            tbname.Size = new Size(275, 27);
            tbname.TabIndex = 5;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = Color.Black;
            password.Location = new Point(50, 352);
            password.Name = "password";
            password.Size = new Size(82, 20);
            password.TabIndex = 6;
            password.Text = "Password:";
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(50, 386);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(275, 27);
            tbpassword.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(193, 419);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.GradientActiveCaption;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.ActiveCaptionText;
            btnlogin.Location = new Point(104, 480);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(153, 40);
            btnlogin.TabIndex = 9;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1275, 724);
            Controls.Add(btnlogin);
            Controls.Add(checkBox1);
            Controls.Add(tbpassword);
            Controls.Add(password);
            Controls.Add(tbname);
            Controls.Add(username);
            Controls.Add(logo);
            Controls.Add(close);
            Controls.Add(signin);
            Controls.Add(background);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "exmetlogin";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)background).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox background;
        private Label signin;
        private PictureBox close;
        private PictureBox logo;
        private Label username;
        private TextBox tbname;
        private Label password;
        private TextBox tbpassword;
        private CheckBox checkBox1;
        private Button btnlogin;
    }
}
