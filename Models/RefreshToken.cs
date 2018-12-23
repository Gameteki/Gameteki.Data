namespace CrimsonDev.Gameteki.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class RefreshToken
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
        public string IpAddress { get; set; }
        public DateTime LastUsed { get; set; }
        public DateTime Expires { get; set; }

        public GametekiUser User { get; set; }
    }
}