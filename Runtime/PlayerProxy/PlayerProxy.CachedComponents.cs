namespace com.eyerunnman.player
{
    public partial class PlayerProxy
    {
        private class CachedComponents
        {
            public Player Player { get; set; }
            public CachedComponents(PlayerProxy playerInvoker)
            {
                Player = playerInvoker.GetComponent<Player>();
            }

        }
    }
}

