namespace CrimsonDev.Gameteki.Data.Models.Patreon
{
    using System.Text.Json.Serialization;

    public class PatreonUser
    {
        [JsonPropertyName("attributes")]
        public PatreonUserAttributes Attributes { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
    }
}
