namespace flappy_bird
{
    public partial class LogInForm : Form
    {
        // Add a property to store the entered username
        public string Username { get; private set; }
        public string Password { get; private set; }

        // Modify your login button click event handler to set the Username property

        public LogInForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set the entered username and password
            txtUsername.Text = Username;
            txtPassword.Text = Password;
            // Validate the login credentials
            if (IsValidLogin(Username, Password))
            {
                // Set the DialogResult to OK to indicate a successful login
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                // Show an error message
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
        private bool IsValidLogin(string username, string password)
        {
            // Perform your validation logic here
            // For demonstration purposes, let's assume a valid login if both username and password are not empty
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
