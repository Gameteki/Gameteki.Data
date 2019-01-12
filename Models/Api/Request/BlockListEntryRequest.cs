namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using System.ComponentModel.DataAnnotations;

    public class BlockListEntryRequest
    {
        [Required]
        public string Username { get; set; }
    }
}