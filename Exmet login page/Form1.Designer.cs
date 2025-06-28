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
            btnlogin1 = new Button();
            pictureBoximg2 = new PictureBox();
            close = new PictureBox();
            pictureBoxlogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoximg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_06_27_at_15_23_55_790459e3;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 769);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnsingup);
            panel1.Controls.Add(btnlogin1);
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
            btnsingup.Location = new Point(563, 297);
            btnsingup.Name = "btnsingup";
            btnsingup.Size = new Size(138, 38);
            btnsingup.TabIndex = 19;
            btnsingup.Text = "Singup";
            btnsingup.UseVisualStyleBackColor = false;
            btnsingup.Click += btnsingup_Click;
            // 
            // btnlogin1
            // 
            btnlogin1.BackColor = SystemColors.ButtonHighlight;
            btnlogin1.Cursor = Cursors.Hand;
            btnlogin1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin1.ForeColor = Color.Blue;
            btnlogin1.ImageAlign = ContentAlignment.TopLeft;
            btnlogin1.Location = new Point(426, 261);
            btnlogin1.Name = "btnlogin1";
            btnlogin1.Size = new Size(136, 33);
            btnlogin1.TabIndex = 16;
            btnlogin1.Text = "Login";
            btnlogin1.UseVisualStyleBackColor = false;
            btnlogin1.Click += btnlogin1_Click;
            // 
            // pictureBoximg2
            // 
            pictureBoximg2.Image = Properties.Resources.WhatsApp_Image_2025_06_27_at_15_23_55_790459e3;
            pictureBoximg2.Location = new Point(0, 0);
            pictureBoximg2.Name = "pictureBoximg2";
            pictureBoximg2.Size = new Size(562, 620);
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
            // pictureBoxlogo
            // 
            pictureBoxlogo.Image = (Image)resources.GetObject("pictureBoxlogo.Image");
            pictureBoxlogo.Location = new Point(590, 8);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(71, 63);
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxlogo.TabIndex = 1;
            pictureBoxlogo.TabStop = false;
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
            Controls.Add(pictureBoxlogo);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "exmetlogin";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoximg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBoximg2;
        private Button btnlogin1;
        private Button btnsingup;
        private PictureBox close;
        private PictureBox pictureBoxlogo;
    }
}
