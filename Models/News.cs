namespace CrimsonDev.Gameteki.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

    public class News
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        [JsonIgnore]
        public string PosterId { get; set; }
        public string Text { get; set; }

        [JsonIgnore]
        public virtual GametekiUser Poster { get; set; }

        [NotMapped]
        [JsonProperty(PropertyName = "poster")]
        public string PosterName => Poster?.UserName;
    }
}