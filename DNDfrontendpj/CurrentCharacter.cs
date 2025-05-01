namespace DNDfrontendpj
{
    internal class CurrentCharacter
    {
        public int CharacterID { get; set; }
        public int CampaignID { get; set; }
        public int CUID { get; set; }
        public string CharacterName { get; set; }

        public CurrentCharacter(int characterID, int campaignID, int cUID, string characterName)
        {
            CharacterID = characterID;
            CampaignID = campaignID;
            CUID = cUID;
            CharacterName = characterName;
        }
    }
}
