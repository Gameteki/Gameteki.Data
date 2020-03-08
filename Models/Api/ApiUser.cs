namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using CrimsonDev.Gameteki.Data.Models.Patreon;

    public class ApiUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public ApiSettings Settings { get; set; }
        public GametekiPermissions GametekiPermissions { get; set; }
        public string CustomData { get; set; }
        public PatreonStatus PatreonStatus { get; set; }
    }
}
