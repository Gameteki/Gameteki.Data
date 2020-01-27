namespace CrimsonDev.Gameteki.Data.Models.Patreon
{
    using System;
    using System.Text.Json.Serialization;

    public class PatreonUserResponse
    {
        [JsonPropertyName("data")]
        public PatreonUser Data { get; set; }
    }
}
