namespace CrimsonDev.Gameteki.Data.Models
{
    using CrimsonDev.Gameteki.Data.Models.Patreon;
    using JsonApiFramework.ServiceModel.Configuration;

    public class PatreonUserConfiguration : ResourceTypeBuilder<PatreonUser>
    {
        public PatreonUserConfiguration()
        {
            this.ResourceIdentity(x => x.Id).SetApiType("user");
            ToManyRelationship<PatreonPledge>("pledges");

            this.Attribute(u => u.FirstName).SetApiPropertyName("first_name");
            this.Attribute(u => u.DiscordId).SetApiPropertyName("discord_id");
            this.Attribute(u => u.FacebookId).SetApiPropertyName("facebook_id");
            this.Attribute(u => u.HasPassword).SetApiPropertyName("has_password");
            this.Attribute(u => u.FullName).SetApiPropertyName("full_name");
            this.Attribute(u => u.ImageUrl).SetApiPropertyName("image_url");
            this.Attribute(u => u.IsDeleted).SetApiPropertyName("is_deleted");
            this.Attribute(u => u.IsEmailVerified).SetApiPropertyName("is_email_verified");
            this.Attribute(u => u.IsNuked).SetApiPropertyName("is_nuked");
            this.Attribute(u => u.IsSuspected).SetApiPropertyName("is_suspected");
            this.Attribute(u => u.LastName).SetApiPropertyName("last_name");
            this.Attribute(u => u.SocialConnections).SetApiPropertyName("social_connections");
            this.Attribute(u => u.ThumbUrl).SetApiPropertyName("thumb_url");
        }
    }
}