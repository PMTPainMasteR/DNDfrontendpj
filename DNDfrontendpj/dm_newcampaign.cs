namespace DNDfrontendpj
{
    public partial class dm_newcampaign : Form
    {
        private int dmID;
        public dm_newcampaign(int uid)
        {
            InitializeComponent();
            this.dmID = uid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //return to all dm campaign overview
            infodao infodao = new infodao();
            dm_allcampaign dm_Allcampaign = new dm_allcampaign(infodao.getAllDMCampaign(UserSession.CurrentUser.UID));
            dm_Allcampaign.Show();
            this.Close();
        }

        private void startcampaignBT_Click(object sender, EventArgs e)
        {
            infodao infodao = new infodao();
            if (!string.IsNullOrWhiteSpace(CampaignName_txtbox.Text) &&
                !string.IsNullOrWhiteSpace(Settingh_rich.Text) &&
                !string.IsNullOrWhiteSpace(Description_rich.Text))
            {
                DM_campaign_info newCampainginfo = new DM_campaign_info()
                {
                    CampaignID = 1,
                    CampaignName = CampaignName_txtbox.Text,
                    Genre = Settingh_rich.Text,
                    DMID = UserSession.CurrentUser.UID,
                    CampaignDescription = Description_rich.Text
                };
                int creatCampaign = infodao.CreateCampaign(newCampainginfo);
                CampaignSession.CurrentCampaign = new CurrentCampaign(infodao.getCurrentCampaignID(), CampaignName_txtbox.Text);
                CampaignSession.CurrentFullCampaign = new CurrentFullCampaign(infodao.getCurrentCampaignID(), CampaignName_txtbox.Text, Settingh_rich.Text, Description_rich.Text);
                dm_playerstat dm_Playerstat = new dm_playerstat(infodao.getAllCharactersInCampaign(CampaignSession.CurrentCampaign.CamID));
                dm_Playerstat.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please filled all the blank", "Some Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dm_newcampaign_Load(object sender, EventArgs e)
        {

        }
    }
}
