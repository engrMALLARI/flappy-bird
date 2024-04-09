namespace flappy_bird
{
    partial class LogInForm
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
            label1 = new Label();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            panel1 = new Panel();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 88);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(190, 184);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 31);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DarkOliveGreen;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(216, 233);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(159, 44);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "LogIn";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OliveDrab;
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(-41, -20);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 62);
            panel1.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(589, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(56, 46);
            btnClose.TabIndex = 0;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ground;
            pictureBox2.Location = new Point(-12, 330);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(631, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(190, 119);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 31);
            txtUsername.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(190, 153);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(106, 28);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password:";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(603, 381);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInForm";
            Text = "Form1";
            Load += LogInForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private Button btnLogIn;
        private Panel panel1;
        private Button btnClose;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private Label lblPassword;
    }
}
