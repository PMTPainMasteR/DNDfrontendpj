namespace DNDfrontendpj
{
    public partial class dm_editchara : Form
    {
        public dm_editchara()
        {
            InitializeComponent();
        }
        public dm_editchara(int CharID, int camID, int CUID, string title, string name, string characterClass, string alignment, string background,
                        int str, int dex, int con, int intel, int wis, int cha, int ac, int hp, int will,
                        string attack1, string attack2, string attack3,
                        string st1, string st2, string st3,
                        string gear1, string gear2, string gear3)
        {
            InitializeComponent();
            charID = CharID;
            edit_camID = camID;
            cuid = CUID;
            edit_title_row = title;
            edit_name_row = name;
            edit_class_row = characterClass;
            edit_alignment_row = alignment;
            edit_background_row = background;
            edit_str_row = str;
            edit_dex_row = dex;
            edit_con_row = con;
            edit_int_row = intel;
            edit_wis_row = wis;
            edit_cha_row = cha;
            edit_ac_row = ac;
            edit_hp_row = hp;
            edit_will_row = will;
            edit_attack1_row = attack1;
            edit_attack2_row = attack2;
            edit_attack3_row = attack3;
            edit_st1_row = st1;
            edit_st2_row = st2;
            edit_st3_row = st3;
            edit_gear1_row = gear1;
            edit_gear2_row = gear2;
            edit_gear3_row = gear3;

        }
        public int charID { get; set; }
        public int edit_camID { get; set; }
        public int cuid { get; set; }
        public string edit_title_row { get; set; }
        public string edit_name_row { get; set; }
        public string edit_class_row { get; set; }
        public string edit_alignment_row { get; set; }
        public string edit_background_row { get; set; }
        public int edit_str_row { get; set; }
        public int edit_dex_row { get; set; }
        public int edit_con_row { get; set; }
        public int edit_int_row { get; set; }
        public int edit_wis_row { get; set; }
        public int edit_cha_row { get; set; }
        public int edit_ac_row { get; set; }
        public int edit_hp_row { get; set; }
        public int edit_will_row { get; set; }
        public string edit_attack1_row { get; set; }
        public string edit_attack2_row { get; set; }
        public string edit_attack3_row { get; set; }
        public string edit_st1_row { get; set; }
        public string edit_st2_row { get; set; }
        public string edit_st3_row { get; set; }
        public string edit_gear1_row { get; set; }
        public string edit_gear2_row { get; set; }
        public string edit_gear3_row { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            infodao infodao = new infodao();
            int strValue = 1, dexValue = 1, conValue = 1, intValue = 1, wisValue = 1, chaValue = 1,
                acValue = 1, willValue = 1, hpValue = 1;
            if (!string.IsNullOrWhiteSpace(camID_tb.Text) &&
                !string.IsNullOrWhiteSpace(title_tb.Text) &&
                !string.IsNullOrWhiteSpace(name_tb.Text) &&
                !string.IsNullOrWhiteSpace(class_tb.Text) &&
                !string.IsNullOrWhiteSpace(align_tb.Text) &&
                !string.IsNullOrWhiteSpace(bg_rtb.Text))
            {
                bool isValid =
                    int.TryParse(str_tb.Text, out strValue) && strValue <= 20 &&
                    int.TryParse(dex_tb.Text, out dexValue) && dexValue <= 20 &&
                    int.TryParse(con_tb.Text, out conValue) && conValue <= 20 &&
                    int.TryParse(int_tb.Text, out intValue) && intValue <= 20 &&
                    int.TryParse(wis_tb.Text, out wisValue) && wisValue <= 20 &&
                    int.TryParse(cha_tb.Text, out chaValue) && chaValue <= 20 &&
                    int.TryParse(AC_tb.Text, out acValue) && acValue <= 20 &&
                    int.TryParse(will_tb.Text, out willValue) && willValue <= 12 &&
                    int.TryParse(hp_tb.Text, out hpValue) && hpValue <= 20;
                if (isValid)
                {
                    CharacterInfo EditChara = new CharacterInfo()
                    {
                        CharacterID = charID,
                        CampaignID = edit_camID,
                        CUID = cuid,
                        Title = title_tb.Text,
                        CharacterName = name_tb.Text,
                        CharacterClass = class_tb.Text,
                        Alignment = align_tb.Text,
                        Background = bg_rtb.Text,
                        STR = strValue,
                        DEX = dexValue,
                        CON = conValue,
                        INT = intValue,
                        WIS = wisValue,
                        CHA = chaValue,
                        AC = acValue,
                        Health = hpValue,
                        Willpower = willValue,
                        CharacterInventoryID = 1,
                        Item1 = string.Empty,
                        Item2 = string.Empty,
                        Item3 = string.Empty,
                        Item4 = string.Empty,
                        Item5 = string.Empty,
                        CharacterGearID = 1,
                        Gear1 = GetTextOrDefault(g1_tb),
                        Gear2 = GetTextOrDefault(g2_tb),
                        Gear3 = GetTextOrDefault(g3_tb),
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
                        int result = infodao.updateChara(EditChara);
                        MessageBox.Show("Update Character Successfully", "Update Character", MessageBoxButtons.OK);
                        dm_playerstat dmplayerstat = new dm_playerstat(infodao.getAllCharactersInCampaign(edit_camID));
                        dmplayerstat.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Character stat should not over 20 or be Integer and Willpower should not over 12", "Stat Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please filled title, name, class, aligment, and background", "Character Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //does nothing

        }

        private void ret2dmcharstat_Click(object sender, EventArgs e)
        {
            infodao infodao = new infodao();
            if (UserSession.CurrentUserIdentified.DM == 1)
            {
                dm_playerstat playerstat = new dm_playerstat(infodao.getAllCharactersInCampaign(edit_camID));
                playerstat.Show();
                this.Close();
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void dm_editchara_Load(object sender, EventArgs e)
        {
            camID_tb.Text = edit_camID.ToString();
            title_tb.Text = edit_title_row;
            name_tb.Text = edit_name_row;
            class_tb.Text = edit_class_row;
            align_tb.Text = edit_alignment_row;
            bg_rtb.Text = edit_background_row;
            str_tb.Text = edit_str_row.ToString();
            dex_tb.Text = edit_dex_row.ToString();
            con_tb.Text = edit_con_row.ToString();
            int_tb.Text = edit_int_row.ToString();
            wis_tb.Text = edit_wis_row.ToString();
            cha_tb.Text = edit_cha_row.ToString();
            AC_tb.Text = edit_ac_row.ToString();
            hp_tb.Text = edit_hp_row.ToString();
            will_tb.Text = edit_will_row.ToString();
            Atk1.Text = edit_attack1_row;
            Atk2.Text = edit_attack2_row;
            Atk3.Text = edit_attack3_row;
            TS1.Text = edit_st1_row;
            TS2.Text = edit_st2_row;
            TS3.Text = edit_st3_row;
            g1_tb.Text = edit_gear1_row;
            g2_tb.Text = edit_gear2_row;
            g3_tb.Text = edit_gear3_row;

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
