namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using System.ComponentModel.DataAnnotations;

    public class LogoutRequest
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}