namespace DNDfrontendpj
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Create an instance of the Signup form
            Signup signupForm = new Signup();

            // Show the Signup form
            this.Hide();
            signupForm.ShowDialog();


            // Optionally, close the current login form if needed
            // this.Close();
        }

        private void nextbt_Click(object sender, EventArgs e)
        {
            infodao infodao = new infodao();
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                // Check if the user is a DM
                int? uid = infodao.isDM(username, password);
                if (uid.HasValue) // If login is successful
                {
                    UserSession.CurrentUser = new CurrentUser((int)uid.Value, username);
                    UserSession.CurrentUserIdentified = new CurrentUserIdentified(1, 0);
                    //MessageBox.Show(UserSession.CurrentUser.UID + "", "UID", MessageBoxButtons.OK);
                    // Go to dm_allcampaign.cs 
                    dm_allcampaign dmallcampaignDB = new dm_allcampaign(infodao.getAllDMCampaign(UserSession.CurrentUser.UID));
                    dmallcampaignDB.Show();
                    this.Hide(); // Hide the login form
                }
                else
                {
                    // Check if the user is a player
                    uid = infodao.isPlayer(username, password);
                    if (uid.HasValue) // If login is successful
                    {
                        UserSession.CurrentUser = new CurrentUser((int)uid.Value, username);
                        UserSession.CurrentUserIdentified = new CurrentUserIdentified(0, 1);
                        // Go to player_welcome.cs
                        player_welcome playerwelcomePAGE = new player_welcome();
                        playerwelcomePAGE.Show();
                        this.Hide(); // Hide the login form
                    }
                    else
                    {
                        // If login fails, show an error message
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.", "Some Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            //does nothing
        }
    }
}
