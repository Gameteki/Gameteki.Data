namespace CrimsonDev.Gameteki.Data.Models.Api
{
    public class LoginResponse : ApiResponse
    {
        public ApiUser User { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}