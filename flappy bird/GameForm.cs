using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class GameForm : Form
    {
        private const int BirdWidth = 50;
        private const int BirdHeight = 50;
        private const int PipeWidth = 50;
        private const int PipeGap = 150;
        private const int PipeSpeed = 5;
        private const int Gravity = 2;

        private System.Windows.Forms.Timer gameTimer;
        private PictureBox bird;
        private PictureBox[] pipes;
        private int score = 0;
        private bool isGameOver = false;

        public GameForm(string username)
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Setup bird
            bird = new PictureBox();
            bird.Image = Properties.Resources.bird;
            bird.Size = new Size(BirdWidth, BirdHeight);
            bird.Location = new Point(50, this.Height / 2 - BirdHeight / 2);
            this.Controls.Add(bird);

            // Setup pipes
            pipes = new PictureBox[5];
            for (int i = 0; i < pipes.Length; i++)
            {
                pipes[i] = new PictureBox();
                pipes[i].Image = Properties.Resources.pipe;
                pipes[i].Size = new Size(PipeWidth, this.Height);
                pipes[i].Location = new Point(this.Width + i * 300, 0);
                pipes[i].Tag = "pipe";
                this.Controls.Add(pipes[i]);
            }
            // Setup ground
            PictureBox ground = new PictureBox();
            ground.Image = Properties.Resources.ground;
            ground.Size = new Size(this.Width, 100);
            ground.Location = new Point(0, this.Height - 100);
            this.Controls.Add(ground);

            // Setup game timer
            System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer ticked!"); // Debug statement
                                                // Move bird
            bird.Top += Gravity;

            // Check for collision with ground or pipes
            if (bird.Bounds.IntersectsWith(this.ClientRectangle) || isGameOver)
            {
                EndGame();
            }
            foreach (PictureBox pipe in pipes)
            {
                pipe.Left -= PipeSpeed;

                // Check for collision with pipes
                if (bird.Bounds.IntersectsWith(pipe.Bounds))
                {
                    EndGame();
                }

                // Check if pipe is off screen
                if (pipe.Right < 0)
                {
                    pipe.Left = this.Width;
                    score++;
                }
            }

            // Update score label
            lblScore.Text = "Score: " + score;

            // Update score label
            lblScore.Text = "Score: " + score;
        }

        private void EndGame()
        {
            isGameOver = true;
            gameTimer.Stop();
            MessageBox.Show("Game Over! Your score: " + score);
            // Add logic to save score or return to main menu
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                bird.Top -= 50;
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
