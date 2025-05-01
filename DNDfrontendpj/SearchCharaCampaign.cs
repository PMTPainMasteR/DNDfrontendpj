namespace DNDfrontendpj
{
    internal class SearchCharaCampaign
    {
        public int CamID { get; set; }
        public string CamName { get; set; }
        public SearchCharaCampaign(int camid, string camname)
        {
            CamID = camid;
            CamName = camname;
        }
    }
}
