namespace flappy_bird
{
    partial class FlappyBirdieForm
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
            label1 = new Label();
            btnLogIn = new Button();
            btnPlayGuest = new Button();
            btnPlay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 82);
            label1.Name = "label1";
            label1.Size = new Size(404, 38);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO FLAPPY BIRDIE";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DimGray;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(322, 160);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(198, 43);
            btnLogIn.TabIndex = 1;
            btnLogIn.Text = "LogIn";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnPlayGuest
            // 
            btnPlayGuest.BackColor = Color.DimGray;
            btnPlayGuest.FlatStyle = FlatStyle.Flat;
            btnPlayGuest.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayGuest.ForeColor = Color.White;
            btnPlayGuest.Location = new Point(322, 240);
            btnPlayGuest.Name = "btnPlayGuest";
            btnPlayGuest.Size = new Size(198, 43);
            btnPlayGuest.TabIndex = 2;
            btnPlayGuest.Text = "Play as Guest";
            btnPlayGuest.UseVisualStyleBackColor = false;
            btnPlayGuest.Click += btnPlayGuest_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.DimGray;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(322, 318);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(198, 43);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Play Game";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // FlappyBirdieForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(864, 598);
            Controls.Add(btnPlay);
            Controls.Add(btnPlayGuest);
            Controls.Add(btnLogIn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlappyBirdieForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogIn;
        private Button btnPlayGuest;
        private Button btnPlay;
    }
}