namespace CrimsonDev.Gameteki.Data.Models
{
    using System;

    public class PatreonToken
    {
        public int Id { get; set; }
        public GametekiUser User { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiry { get; set; }
    }
}
