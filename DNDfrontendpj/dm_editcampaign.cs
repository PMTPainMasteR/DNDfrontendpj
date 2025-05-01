namespace DNDfrontendpj
{
    public partial class dm_editcampaign : Form
    {
        public string newstatus;
        public dm_editcampaign()
        {
            InitializeComponent();
        }
        public dm_editcampaign(int id, string name, string genre, string description)
        {
            InitializeComponent();
            V = id;
            EditName = name;
            EditGenre = genre;
            EditDescription = description;
        }
        public int V { get; set; }
        public string EditName { get; set; }
        public string EditGenre { get; set; }
        public string EditDescription { get; set; }
        private void ret2camdbBT_Click(object sender, EventArgs e)
        {
            infodao infodao = new infodao();
            if (radioButton1.Checked)
            {
                newstatus = "Ongoing";
                DM_campaign_info editInfo = new DM_campaign_info()
                {
                    CampaignID = V,
                    CampaignName = textBox1.Text,
                    Genre = richTextBox2.Text,
                    Status = newstatus,
                    DMID = UserSession.CurrentUser.UID,
                    CampaignDescription = richTextBox1.Text
                };
                CampaignSession.CurrentCampaign = new CurrentCampaign(editInfo.CampaignID, editInfo.CampaignName);
                CampaignSession.CurrentFullCampaign = new CurrentFullCampaign(editInfo.CampaignID, editInfo.CampaignName, editInfo.Genre, editInfo.CampaignDescription);
                int result = infodao.updateCampaign(editInfo);
                dm_allcampaign new_dm_Allcampaign = new dm_allcampaign(infodao.getAllDMCampaign(UserSession.CurrentUser.UID));
                new_dm_Allcampaign.Show();
                this.Close();
            }
            else if (radioButton2.Checked)
            {
                newstatus = "Finished";
                DM_campaign_info editInfo = new DM_campaign_info()
                {
                    CampaignID = V,
                    CampaignName = textBox1.Text,
                    Genre = richTextBox2.Text,
                    Status = newstatus,
                    DMID = UserSession.CurrentUser.UID,
                    CampaignDescription = richTextBox1.Text
                };
                CampaignSession.CurrentCampaign = new CurrentCampaign(editInfo.CampaignID, editInfo.CampaignName);
                int result = infodao.updateCampaign(editInfo);
                dm_allcampaign new_dm_Allcampaign = new dm_allcampaign(infodao.getAllDMCampaign(UserSession.CurrentUser.UID));
                new_dm_Allcampaign.Show();
                this.Close();
            }
            else if (radioButton3.Checked)
            {
                newstatus = "Drop";
                DM_campaign_info editInfo = new DM_campaign_info()
                {
                    CampaignID = V,
                    CampaignName = textBox1.Text,
                    Genre = richTextBox2.Text,
                    Status = newstatus,
                    DMID = UserSession.CurrentUser.UID,
                    CampaignDescription = richTextBox1.Text
                };
                CampaignSession.CurrentCampaign = new CurrentCampaign(editInfo.CampaignID, editInfo.CampaignName);
                int result = infodao.deleteOneCampaign(editInfo.CampaignID);
                dm_allcampaign new_dm_Allcampaign = new dm_allcampaign(infodao.getAllDMCampaign(UserSession.CurrentUser.UID));
                MessageBox.Show("Campaign Drop successfully", "Delete Campaign", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new_dm_Allcampaign.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check one of radio button", "Status not define", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dm_editcampaign_Load(object sender, EventArgs e)
        {
            textBox1.Text = EditName;
            richTextBox2.Text = EditGenre;
            richTextBox1.Text = EditDescription;
        }
    }
}
