namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using System.ComponentModel.DataAnnotations;

    public class AddMessageRequest
    {
        [Required]
        [MaxLength(512)]
        public string Message { get; set; }
    }
}
