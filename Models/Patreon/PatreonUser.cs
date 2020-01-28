namespace CrimsonDev.Gameteki.Data.Models.Patreon
{
    using System.Text.Json.Serialization;

    public class PatreonUser
    {
        public PatreonUserAttributes Attributes { get; set; }
        public string Id { get; set; }
        public PatreonRelationships Relationships { get; set; }
        public string Type { get; set; }
    }
}
