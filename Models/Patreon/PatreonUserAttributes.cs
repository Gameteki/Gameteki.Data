namespace CrimsonDev.Gameteki.Data.Models.Patreon
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("ReSharper", "CA1056", Justification = "Patreon API")]
    public class PatreonUserAttributes
    {
        public string About { get; set; }
        public DateTime Created { get; set; }
        public string DiscordId { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string FacebookId { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public bool HasPassword { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsNuked { get; set; }
        public bool IsSuspected { get; set; }
        public string LastName { get; set; }
        public string ThumbUrl { get; set; }
        public string Twitch { get; set; }
        public string Twitter { get; set; }
        public string Url { get; set; }
        public string Vanity { get; set; }
        public string Youtube { get; set; }
        public PatreonGender Gender { get; set; }
        public PatreonSocialConnections PatreonSocialConnections { get; set; }
    }
}
