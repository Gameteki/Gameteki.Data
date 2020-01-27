namespace CrimsonDev.Gameteki.Data.Models
{
    public class LoginResult
    {
        public GametekiUser User { get; set; }
        public GametekiPermissions GametekiPermissions { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}