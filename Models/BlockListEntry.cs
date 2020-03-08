namespace CrimsonDev.Gameteki.Data.Models
{
    public class BlockListEntry
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string BlockedUser { get; set; }

        public GametekiUser User { get; set; }
    }
}