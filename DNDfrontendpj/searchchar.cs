namespace DNDfrontendpj
{
    public partial class searchchar : Form
    {
        public searchchar()
        {
            InitializeComponent();
        }

        private void searchcharBT_Click(object sender, EventArgs e)
        {
            infodao infodao = new infodao();
            //show cearch character
            if (UserSession.CurrentUserIdentified.DM == 1)
            {
                CampaignSession.CurrentCampaign = new CurrentCampaign(0, "Search Characters");
                dm_playerstat dm_Playerstat = new dm_playerstat(infodao.searchCharacter(searchchar_TB.Text));
                dm_Playerstat.Show();
                this.Close();
            }
            //close window after search

        }
    }
}
