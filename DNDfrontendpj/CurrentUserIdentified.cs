namespace DNDfrontendpj
{
    internal class CurrentUserIdentified
    {
        public int DM { get; set; }
        public int PLAYER { get; set; }
        public CurrentUserIdentified(int dm, int player)
        {
            DM = dm;
            PLAYER = player;
        }
    }
}
