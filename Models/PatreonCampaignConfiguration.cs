namespace CrimsonDev.Gameteki.Data.Models
{
    using CrimsonDev.Gameteki.Data.Models.Patreon;
    using JsonApiFramework.ServiceModel.Configuration;

    public class PatreonCampaignConfiguration : ResourceTypeBuilder<PatreonCampaign>
    {
        public PatreonCampaignConfiguration()
        {
            this.ResourceIdentity(x => x.Id).SetApiType("campaign");
        }
    }
}