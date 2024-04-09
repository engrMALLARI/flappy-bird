using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace flappy_bird
{
    public partial class FlappyBirdieForm : Form
    {
        private bool loggedIn = false;
        private string username = "";
        public FlappyBirdieForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Show the login form
            using (LogInForm loginForm = new LogInForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Update loggedIn and username based on the login form result
                    loggedIn = true;
                    username = loginForm.Username;
                    MessageBox.Show($"Welcome, {username}!");

                    // Open the FlappyBirdieForm after successful login
                    FlappyBirdieForm flappyBirdieForm = new FlappyBirdieForm();
                    flappyBirdieForm.ShowDialog();
                }
            }
        }

        private void btnPlayGuest_Click(object sender, EventArgs e)
        {
            // Play the game as a guest
            PlayGame();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Play the game if logged in, otherwise prompt to login
            if (loggedIn)
            {
                PlayGame();
            }
            else
            {
                MessageBox.Show("Please login to play the game.");
            }
        }

        private void PlayGame()
        {
            // Show the game form
            GameForm gameForm = new GameForm(username);
            gameForm.ShowDialog();
        }
    }
}
