namespace DNDfrontendpj
{

    internal class CurrentFullCharacter
    {
        public int CharacterID { get; set; }
        public int CampaignID { get; set; }
        public int CUID { get; set; }
        public string Title { get; set; }
        public string CharacterName { get; set; }
        public string CharacterClass { get; set; }
        public string Alignment { get; set; }
        public string Background { get; set; }
        public int STR { get; set; }
        public int DEX { get; set; }
        public int CON { get; set; }
        public int INT { get; set; }
        public int WIS { get; set; }
        public int CHA { get; set; }
        public int AC { get; set; }
        public int Health { get; set; }
        public int Willpower { get; set; }
        public int CharacterInventoryID { get; set; }
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
        public string Item5 { get; set; }
        public int CharacterGearID { get; set; }
        public string Gear1 { get; set; }
        public string Gear2 { get; set; }
        public string Gear3 { get; set; }
        public int CharacterAttackID { get; set; }
        public string Attack1 { get; set; }
        public string Attack2 { get; set; }
        public string Attack3 { get; set; }
        public int CharacterSpellTalentID { get; set; }
        public string ST1 { get; set; }
        public string ST2 { get; set; }
        public string ST3 { get; set; }
        public CurrentFullCharacter(int characterID, int campaignID, int cUID, string title, string characterName,
                             string characterClass, string alignment, string background, int str,
                             int dex, int con, int intScore, int wis, int cha, int ac,
                             int health, int willpower, int characterInventoryID,
                             string item1, string item2, string item3, string item4, string item5,
                             int characterGearID, string gear1, string gear2, string gear3,
                             int characterAttackID, string attack1, string attack2, string attack3,
                             int characterSpellTalentID, string st1, string st2, string st3)
        {
            CharacterID = characterID;
            CampaignID = campaignID;
            CUID = cUID;
            Title = title;
            CharacterName = characterName;
            CharacterClass = characterClass;
            Alignment = alignment;
            Background = background;
            STR = str;
            DEX = dex;
            CON = con;
            INT = intScore;
            WIS = wis;
            CHA = cha;
            AC = ac;
            Health = health;
            Willpower = willpower;
            CharacterInventoryID = characterInventoryID;
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            CharacterGearID = characterGearID;
            Gear1 = gear1;
            Gear2 = gear2;
            Gear3 = gear3;
            CharacterAttackID = characterAttackID;
            Attack1 = attack1;
            Attack2 = attack2;
            Attack3 = attack3;
            CharacterSpellTalentID = characterSpellTalentID;
            ST1 = st1;
            ST2 = st2;
            ST3 = st3;
        }
    }
}
