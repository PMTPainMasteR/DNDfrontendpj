namespace DNDfrontendpj
{
    public partial class player_welcome : Form
    {
        public player_welcome()
        {
            InitializeComponent();
        }

        private void player_welcome_Load(object sender, EventArgs e)
        {

        }

        private void continuecamBT_Click(object sender, EventArgs e)
        {
            character_stat playercharstat = new character_stat();
            playercharstat.Show();
            this.Close();
        }

        private void createnewcam_Click(object sender, EventArgs e)
        {
            //i wrote the button name wrong na
            //this will go to the create new character
            createnewchara createnewchara = new createnewchara();
            createnewchara.Show();
            this.Close();
        }
    }
}
