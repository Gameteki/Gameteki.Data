namespace CrimsonDev.Gameteki.Data.Models
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class GametekiUser : IdentityUser
    {
        public DateTime RegisteredDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string RegisterIp { get; set; }
        public string EmailHash { get; set; }
        public UserSettings Settings { get; set; }
        public bool Disabled { get; set; }

        public string CustomData { get; set; }

        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
        public virtual ICollection<BlockListEntry> BlockList { get; set; }
        public virtual ICollection<GametekiUserRole> UserRoles { get; set; }
    }
}