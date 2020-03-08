namespace CrimsonDev.Gameteki.Data.Models
{
    using System;
    using System.Collections.Generic;

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Entity framework properties")]
    public class GametekiUser
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime RegisteredDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string RegisterIp { get; set; }
        public string EmailHash { get; set; }
        public UserSettings Settings { get; set; }
        public bool Disabled { get; set; }

        public string CustomData { get; set; }

        public PatreonToken PatreonToken { get; set; }
        public int? PatreonTokenId { get; set; }

        public virtual ICollection<BlockListEntry> BlockList { get; set; }
        public virtual ICollection<GametekiUserRole> UserRoles { get; set; }
    }
}
