namespace DNDfrontendpj
{
    public partial class dm_playerstat : Form
    {
        public int rowClicked;
        public int id_row;
        public string name_row;
        public int camid_row;
        public int cuid_row;
        public string title_row;
        public string class_row;
        public string alignment_row;
        public string background_row;
        public int str_row;
        public int dex_row;
        public int con_row;
        public int int_row;
        public int wis_row;
        public int cha_row;
        public int ac_row;
        public int hp_row;
        public int will_row;
        public string attack1_row;
        public string attack2_row;
        public string attack3_row;
        public string st1_row;
        public string st2_row;
        public string st3_row;
        public string gear1_row;
        public string gear2_row;
        public string gear3_row;

        BindingSource infobindingSource = new BindingSource();
        public dm_playerstat()
        {
            InitializeComponent();
        }
        public dm_playerstat(object v)
        {
            InitializeComponent();
            V2 = v;
        }
        public object V2 { get; set; }
        private void viewinvenBT_Click(object sender, EventArgs e)
        {
            if (CampaignSession.CurrentCampaign.CamID == 0)
            {
                CampaignSession.CurrentCampaign = new CurrentCampaign(CampaignSession.CurrentFullCampaign.CamID, CampaignSession.CurrentFullCampaign.CamName);
            }
            player_inventory inventory = new player_inventory();
            inventory.Show();
            this.Close();
        }

        private void addnewcharBT_Click(object sender, EventArgs e)
        {
            if (CampaignSession.CurrentCampaign.CamID == 0)
            {
                CampaignSession.CurrentCampaign = new CurrentCampaign(CampaignSession.CurrentFullCampaign.CamID, CampaignSession.CurrentFullCampaign.CamName);
            }
            createnewchara createnewchara = new createnewchara(CampaignSession.CurrentFullCampaign.CamID, UserSession.CurrentUser.UID);
            createnewchara.Show();
            this.Close();
        }

        private void searchcharBT_Click(object sender, EventArgs e)
        {
            searchchar searchchar = new searchchar();
            searchchar.Show();
            this.Close();

        }

        private void EditcharacterBT_Click(object sender, EventArgs e)
        {
            if (CampaignSession.CurrentCampaign.CamID == 0)
            {
                CampaignSession.CurrentCampaign = new CurrentCampaign(CampaignSession.CurrentFullCampaign.CamID, CampaignSession.CurrentFullCampaign.CamName);
            }
            if (CampaignSession.CurrentCampaignDMID.currentDMID == UserSession.CurrentUser.UID)
            {
                dm_editchara dm_Editchara = new dm_editchara(id_row, camid_row, cuid_row, title_row, name_row, class_row, alignment_row,
                    background_row, str_row, dex_row, con_row, int_row, wis_row, cha_row, ac_row, hp_row, will_row, attack1_row,
                    attack2_row, attack3_row, st1_row, st2_row, st3_row, gear1_row, gear2_row, gear3_row);
                dm_Editchara.Show();
                this.Close();
            }
            else
            {
                if (UserSession.CurrentUser.UID == cuid_row)
                {
                    dm_editchara dm_Editchara = new dm_editchara(id_row, camid_row, cuid_row, title_row, name_row, class_row, alignment_row,
                    background_row, str_row, dex_row, con_row, int_row, wis_row, cha_row, ac_row, hp_row, will_row, attack1_row,
                    attack2_row, attack3_row, st1_row, st2_row, st3_row, gear1_row, gear2_row, gear3_row);
                    dm_Editchara.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You cannot edit other character are not owned.", "This Character is not belong to you", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editcampaignBT_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser.UID == CampaignSession.CurrentCampaignDMID.currentDMID)
            {
                if (CampaignSession.CurrentCampaign.CamID == 0)
                {
                    CampaignSession.CurrentCampaign = new CurrentCampaign(CampaignSession.CurrentFullCampaign.CamID, CampaignSession.CurrentFullCampaign.CamName);
                }
                dm_editcampaign dm_Editcampaign = new dm_editcampaign(CampaignSession.CurrentFullCampaign.CamID,
                    CampaignSession.CurrentFullCampaign.CamName, CampaignSession.CurrentFullCampaign.CamGenre,
                    CampaignSession.CurrentFullCampaign.CamDes);
                dm_Editcampaign.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You cannot edit campaign you are not owned.", "This Campaign is not belong to you", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dm_playerstat_Load(object sender, EventArgs e)
        {
            // Set DataGridView properties
            charstat_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Disable auto-sizing
            charstat_DGV.ScrollBars = ScrollBars.Horizontal; // Enable horizontal scrolling
            // Set fixed widths for columns
            for (int i = 0; i < charstat_DGV.Columns.Count; i++)
            {
                charstat_DGV.Columns[i].Width = 100; // Set each column width to 100 pixels
            }
            label3.Text = CampaignSession.CurrentCampaign.CamName;
            infobindingSource.DataSource = V2;
            charstat_DGV.DataSource = infobindingSource;
        }

        private void charstat_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            infodao infodao = new infodao();
            dm_allcampaign dmallcampaignDB = new dm_allcampaign(infodao.getAllDMCampaign(UserSession.CurrentUser.UID));
            dmallcampaignDB.Show();
            this.Hide();
        }

        private void charstat_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // Check if the clicked row index is valid
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                rowClicked = dataGridView.CurrentRow.Index;

                // Safely access the cells with error checking
                if (dataGridView.Columns.Count > 4) // Check for the 5th column
                {
                    var nameRow = dataGridView.Rows[rowClicked].Cells[4].Value;
                    name_row = nameRow != null ? nameRow.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 0) // Check for the 1st column
                {
                    id_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[0].Value.ToString());
                }

                if (dataGridView.Columns.Count > 1) // Check for the 2nd column
                {
                    camid_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[1].Value.ToString());
                }
                if (dataGridView.Columns.Count > 2) // Check for the 3rd column
                {
                    cuid_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[2].Value.ToString());
                }

                if (dataGridView.Columns.Count > 3) // Check for the 4th column
                {
                    var titleRow = dataGridView.Rows[rowClicked].Cells[3].Value;
                    title_row = titleRow != null ? titleRow.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 5) // Check for the 6th column
                {
                    var classRow = dataGridView.Rows[rowClicked].Cells[5].Value;
                    class_row = classRow != null ? classRow.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 6) // Check for the 7th column
                {
                    var alignmentRow = dataGridView.Rows[rowClicked].Cells[6].Value;
                    alignment_row = alignmentRow != null ? alignmentRow.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 7) // Check for the 8th column
                {
                    var backgroundRow = dataGridView.Rows[rowClicked].Cells[7].Value;
                    background_row = backgroundRow != null ? backgroundRow.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 8) // Check for the 9th column
                {
                    str_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[8].Value.ToString());
                }

                if (dataGridView.Columns.Count > 9) // Check for the 10th column
                {
                    dex_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[9].Value.ToString());
                }

                if (dataGridView.Columns.Count > 10) // Check for the 11th column
                {
                    con_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[10].Value.ToString());
                }

                if (dataGridView.Columns.Count > 11) // Check for the 12th column
                {
                    int_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[11].Value.ToString());
                }

                if (dataGridView.Columns.Count > 12) // Check for the 13th column
                {
                    wis_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[12].Value.ToString());
                }

                if (dataGridView.Columns.Count > 13) // Check for the 14th column
                {
                    cha_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[13].Value.ToString());
                }

                if (dataGridView.Columns.Count > 14) // Check for the 15th column
                {
                    ac_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[14].Value.ToString());
                }

                if (dataGridView.Columns.Count > 15) // Check for the 16th column
                {
                    hp_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[15].Value.ToString());
                }

                if (dataGridView.Columns.Count > 16) // Check for the 17th column
                {
                    will_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[16].Value.ToString());
                }

                if (dataGridView.Columns.Count > 24) // Check for the 25 th column
                {
                    var gear1Row = dataGridView.Rows[rowClicked].Cells[24].Value;
                    gear1_row = gear1Row != null ? gear1Row.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 25) // Check for the 26th column
                {
                    var gear2Row = dataGridView.Rows[rowClicked].Cells[25].Value;
                    gear2_row = gear2Row != null ? gear2Row.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 26) // Check for the 27th column
                {
                    var gear3Row = dataGridView.Rows[rowClicked].Cells[26].Value;
                    gear3_row = gear3Row != null ? gear3Row.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 28) // Check for the 32nd column
                {
                    var attack1Row = dataGridView.Rows[rowClicked].Cells[28].Value;
                    attack1_row = attack1Row != null ? attack1Row.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 29) // Check for the 33rd column
                {
                    var attack2Row = dataGridView.Rows[rowClicked].Cells[29].Value;
                    attack2_row = attack2Row != null ? attack2Row.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 30) // Check for the 34th column
                {
                    var attack3Row = dataGridView.Rows[rowClicked].Cells[30].Value;
                    attack3_row = attack3Row != null ? attack3Row.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 32) // Check for the 37th column
                {
                    var st1Row = dataGridView.Rows[rowClicked].Cells[32].Value;
                    st1_row = st1Row != null ? st1Row.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 33) // Check for the 38th column
                {
                    var st2Row = dataGridView.Rows[rowClicked].Cells[33].Value;
                    st2_row = st2Row != null ? st2Row.ToString() : string.Empty;
                }

                if (dataGridView.Columns.Count > 34) // Check for the 39th column
                {
                    var st3Row = dataGridView.Rows[rowClicked].Cells[34].Value;
                    st3_row = st3Row != null ? st3Row.ToString() : string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Invalid row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CampaignSession.CurrentCampaign.CamID == 0)
            {
                CampaignSession.CurrentCampaign = new CurrentCampaign(CampaignSession.CurrentFullCampaign.CamID, CampaignSession.CurrentFullCampaign.CamName);
            }
            if (UserSession.CurrentUser.UID == CampaignSession.CurrentCampaignDMID.currentDMID)
            {
                infodao infodao = new infodao();
                int result = infodao.deleteOneChara(id_row);
                V2 = infodao.getAllCharactersInCampaign(CampaignSession.CurrentCampaign.CamID);
                infobindingSource.DataSource = V2;
                charstat_DGV.DataSource = infobindingSource;
            }
            else
            {
                if (UserSession.CurrentUser.UID == cuid_row)
                {
                    infodao infodao = new infodao();
                    int result = infodao.deleteOneChara(id_row);
                    V2 = infodao.getAllCharactersInCampaign(CampaignSession.CurrentCampaign.CamID);
                    infobindingSource.DataSource = V2;
                    charstat_DGV.DataSource = infobindingSource;
                }
                else
                {
                    MessageBox.Show("You cannot delete other character are not owned.", "This Character is not belong to you", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

