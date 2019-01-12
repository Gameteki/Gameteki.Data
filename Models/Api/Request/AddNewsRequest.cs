namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using System.ComponentModel.DataAnnotations;

    public class AddNewsRequest
    {
        [Required]
        [MaxLength(512)]
        public string Text { get; set; }
    }
}
