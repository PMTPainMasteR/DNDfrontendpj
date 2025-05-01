namespace DNDfrontendpj
{
    internal class CurrentUser
    {
        public int UID { get; set; }
        public string Name { get; set; }
        public CurrentUser(int uid, string username)
        {
            UID = uid;
            Name = username;
        }
    }
}
