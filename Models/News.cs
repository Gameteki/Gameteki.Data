namespace CrimsonDev.Gameteki.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    public class News
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        [JsonIgnore]
        public int PosterId { get; set; }

        [JsonPropertyName("newsText")]
        public string Text { get; set; }

        [JsonIgnore]
        public virtual GametekiUser Poster { get; set; }

        [NotMapped]
        [JsonPropertyName("poster")]
        public string PosterName => Poster?.UserName;
    }
}