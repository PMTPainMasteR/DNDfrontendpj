namespace DNDfrontendpj
{
    public partial class dm_allcampaign : Form
    {
        public int rowClicked;
        public int id_row;
        public string name_row;
        public string genre_row;
        public string description_row;
        public int DMID_row;

        BindingSource infobindingSource = new BindingSource();
        public dm_allcampaign()
        {
            InitializeComponent();
        }
        public dm_allcampaign(object v)
        {
            InitializeComponent();
            V = v;
        }
        public object V { get; set; }
        private void ret2dmallcampaignBT_Click(object sender, EventArgs e)
        {
            //wrong name eeklaew ret2dmallcampaignBT_Click -> return to login
            login login = new login();
            login.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //search for campaign id to see the database on the same page
            //not close page
            infodao infodao = new infodao();
            if (!string.IsNullOrWhiteSpace(searchcam_TB.Text))
            {
                if (int.TryParse(searchcam_TB.Text, out int campaignId))
                {
                    int searchID = Convert.ToInt32(searchcam_TB.Text);
                    var campaignData = infodao.getOneDMCampaign(searchcam_TB.Text);
                    if (campaignData != null && campaignData.Any())
                    {
                        infobindingSource.DataSource = campaignData;
                        cam_DGV.DataSource = infobindingSource;
                    }
                    else
                    {
                        MessageBox.Show("No campaign found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (searchcam_TB.Text == "All" || searchcam_TB.Text == "all")
                {
                    var AllCampaignData = infodao.getAllCampaign();
                    if (AllCampaignData != null && AllCampaignData.Any())
                    {
                        infobindingSource.DataSource = AllCampaignData;
                        cam_DGV.DataSource = infobindingSource;
                    }
                    else
                    {
                        MessageBox.Show("No campaign found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var campaignData = infodao.getOneDMCampaign(searchcam_TB.Text);
                    if (campaignData != null && campaignData.Any())
                    {
                        infobindingSource.DataSource = campaignData;
                        cam_DGV.DataSource = infobindingSource;
                    }
                    else
                    {
                        MessageBox.Show("No campaign found with the specified Name, Genre, Status, and Description.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var campaignData = infodao.getAllDMCampaign(UserSession.CurrentUser.UID);
                if (campaignData != null && campaignData.Any())
                {
                    infobindingSource.DataSource = campaignData;
                    cam_DGV.DataSource = infobindingSource;
                }
                else
                {
                    MessageBox.Show("No campaign found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dm_newcampaign dm_Newcampaign = new dm_newcampaign(UserSession.CurrentUser.UID);
            dm_Newcampaign.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser.UID == DMID_row)
            {
                infodao infodao = new infodao();
                CampaignSession.CurrentCampaign = new CurrentCampaign(id_row, name_row);
                dm_editcampaign dm_Editcampaign = new dm_editcampaign(id_row, name_row, genre_row, description_row);
                CampaignSession.CurrentCampaignDMID = new CurrentCampaignDMID(DMID_row);
                dm_Editcampaign.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You cannot edit campaign you are not owned.", "This Campaign is not belong to you", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void continuecampBT_Click(object sender, EventArgs e)
        {
            infodao infodao = new infodao();
            CampaignSession.CurrentCampaign = new CurrentCampaign(id_row, name_row);
            CampaignSession.CurrentFullCampaign = new CurrentFullCampaign(id_row, name_row, genre_row, description_row);
            CampaignSession.CurrentCampaignDMID = new CurrentCampaignDMID(DMID_row);
            dm_playerstat dm_Playerstat = new dm_playerstat(infodao.getAllCharactersInCampaign(id_row));
            dm_Playerstat.Show();
            this.Close();
        }

        private void dm_allcampaign_Load(object sender, EventArgs e)
        {
            infobindingSource.DataSource = V;
            cam_DGV.DataSource = infobindingSource;
        }
        private void charstat_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            rowClicked = dataGridView.CurrentRow.Index;
            var nameRow = dataGridView.Rows[rowClicked].Cells[1].Value;
            if (nameRow != null)
            {
                name_row = nameRow.ToString();
            }
            else
            {
                name_row = string.Empty;
            }
            id_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[0].Value.ToString());
            var genreRow = dataGridView.Rows[rowClicked].Cells[2].Value;
            if (genreRow != null)
            {
                genre_row = genreRow.ToString();
            }
            else
            {
                genre_row = string.Empty;
            }
            var descriptionRow = dataGridView.Rows[rowClicked].Cells[5].Value;
            if (descriptionRow != null)
            {
                description_row = descriptionRow.ToString();
            }
            else
            {
                description_row = string.Empty;
            }
            DMID_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[4].Value.ToString());
        }

        private void cam_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser.UID == DMID_row)
            {
                infodao infodao = new infodao();
                int result = infodao.deleteOneCampaign(id_row);
                V = infodao.getAllDMCampaign(UserSession.CurrentUser.UID);
                infobindingSource.DataSource = V;
                cam_DGV.DataSource = infobindingSource;
            }
            else
            {
                MessageBox.Show("You cannot delete campaign you are not owned.", "This Campaign is not belong to you", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
