namespace DNDfrontendpj
{
    public partial class player_inventory : Form
    {
        public player_inventory()
        {
            InitializeComponent();
        }

        private void viewcharstatBT_Click(object sender, EventArgs e)
        {
            //if the user is a player show player_charstat
            character_stat newplayercharstat = new character_stat();
            newplayercharstat.Show();
            this.Close();

            //if the user is a dm show dm_charstat
            dm_playerstat dm_Playerstat = new dm_playerstat();
            dm_Playerstat.Show();
            this.Close();
        }

        private void searchcharBT_Click(object sender, EventArgs e)
        {
            searchchar searchchar = new searchchar();
            searchchar.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //return to welcome player
            player_welcome player_Welcome = new player_welcome();
            player_Welcome.Show();
            this.Close();
        }

        private void charstat_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
