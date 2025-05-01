namespace DNDfrontendpj
{
    internal class CurrentFullCampaign
    {
        public int CamID { get; set; }
        public string CamName { get; set; }
        public string CamGenre { get; set; }
        public string CamDes { get; set; }
        public CurrentFullCampaign(int camid, string camname, string camGenre, string camDes)
        {
            CamID = camid;
            CamName = camname;
            CamGenre = camGenre;
            CamDes = camDes;
        }
    }
}
