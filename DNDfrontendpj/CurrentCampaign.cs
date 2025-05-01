namespace DNDfrontendpj
{
    internal class CurrentCampaign
    {
        public int CamID { get; set; }
        public string CamName { get; set; }
        public CurrentCampaign(int camid, string camname)
        {
            CamID = camid;
            CamName = camname;
        }
    }
}
