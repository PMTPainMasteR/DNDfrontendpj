namespace DNDfrontendpj
{
    public partial class createnewchara : Form
    {
        public createnewchara()
        {
            InitializeComponent();
        }
        public createnewchara(int camID, int uid)
        {
            InitializeComponent();
            CamID = camID;
            currentUID = uid;
        }
        public int CamID { get; set; }
        public int currentUID { get; set; }
        private void saveandrettocampaignDB_Click(object sender, EventArgs e)
        {
            infodao infodao = new infodao();
            int strValue = 1, dexValue = 1, conValue = 1, intValue = 1, wisValue = 1, chaValue = 1, acValue = 1;
            if (!string.IsNullOrWhiteSpace(CamID_tb.Text) &&
                !string.IsNullOrWhiteSpace(title_tb.Text) &&
                !string.IsNullOrWhiteSpace(Name_tb.Text) &&
                !string.IsNullOrWhiteSpace(Class_tb.Text) &&
                !string.IsNullOrWhiteSpace(Align_tb.Text) &&
                !string.IsNullOrWhiteSpace(BG_rtb.Text))
            {
                bool isValid =
                    int.TryParse(STR_tb.Text, out strValue) && strValue <= 20 &&
                    int.TryParse(DEX_tb.Text, out dexValue) && dexValue <= 20 &&
                    int.TryParse(CON_tb.Text, out conValue) && conValue <= 20 &&
                    int.TryParse(INT_tb.Text, out intValue) && intValue <= 20 &&
                    int.TryParse(WIS_tb.Text, out wisValue) && wisValue <= 20 &&
                    int.TryParse(CHA_tb.Text, out chaValue) && chaValue <= 20 &&
                    int.TryParse(AC_tb.Text, out acValue) && acValue <= 20;
                if (isValid)
                {
                    CharacterInfo NewChara = new CharacterInfo()
                    {
                        CharacterID = 1,
                        CampaignID = CamID,
                        CUID = currentUID,
                        Title = title_tb.Text,
                        CharacterName = Name_tb.Text,
                        CharacterClass = Class_tb.Text,
                        Alignment = Align_tb.Text,
                        Background = BG_rtb.Text,
                        STR = strValue,
                        DEX = dexValue,
                        CON = conValue,
                        INT = intValue,
                        WIS = wisValue,
                        CHA = chaValue,
                        AC = acValue,
                        Health = 20,
                        Willpower = 12,
                        CharacterInventoryID = 1,
                        Item1 = string.Empty,
                        Item2 = string.Empty,
                        Item3 = string.Empty,
                        Item4 = string.Empty,
                        Item5 = string.Empty,
                        CharacterGearID = 1,
                        Gear1 = GetTextOrDefault(G1_tb),
                        Gear2 = GetTextOrDefault(G2_tb),
                        Gear3 = GetTextOrDefault(G3_tb),
                        CharacterAttackID = 1,
                        Attack1 = GetTextOrDefaultr(Atk1),
                        Attack2 = GetTextOrDefaultr(Atk2),
                        Attack3 = GetTextOrDefaultr(Atk3),
                        CharacterSpellTalentID = 1,
                        ST1 = GetTextOrDefaultr(TS1),
                        ST2 = GetTextOrDefaultr(TS2),
                        ST3 = GetTextOrDefaultr(TS3),
                    };
                    if (UserSession.CurrentUserIdentified.DM == 1)
                    {
                        int result = infodao.addCharacter(NewChara);
                        MessageBox.Show("Create New Character Successfully", "Create New Character", MessageBoxButtons.OK);
                        dm_playerstat dmplayerstat = new dm_playerstat(infodao.getAllCharactersInCampaign(CamID));
                        dmplayerstat.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Character stat should not over 20 or be Integer", "Stat Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please filled title, name, class, aligment, and background", "Character Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if the user is dm go to dm exclusive db
            // Create an instance

            //if the user is player go to player db
            //character_stat playercharDB = new character_stat();
            //playercharDB.Show();
            //this.Close();
        }

        private void retBT_Click(object sender, EventArgs e)
        {
            infodao infodao = new infodao();
            //if player click this button it will return to welcome player
            //player_welcome player_Welcome = new player_welcome();
            //player_Welcome.Show();
            //this.Close();

            //if a dm click this button, it will return to the dm_playerstats
            if (UserSession.CurrentUserIdentified.DM == 1)
            {
                dm_playerstat playerstat = new dm_playerstat(infodao.getAllCharactersInCampaign(CamID));
                playerstat.Show();
                this.Close();
            }
        }

        private void createnewchara_Load(object sender, EventArgs e)
        {
            CamID_tb.Text = CamID.ToString();
        }
        private string GetTextOrDefault(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text) ? string.Empty : textBox.Text;
        }
        private string GetTextOrDefaultr(RichTextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text) ? string.Empty : textBox.Text;
        }
    }
}
