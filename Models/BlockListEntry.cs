namespace CrimsonDev.Gameteki.Data.Models
{
    public class BlockListEntry
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string BlockedUser { get; set; }

        public GametekiUser User { get; set; }
    }
}