namespace CrimsonDev.Gameteki.Data.Models
{
    using CrimsonDev.Gameteki.Data.Models.Patreon;
    using JsonApiFramework.ServiceModel.Configuration;

    public class PatreonRewardConfiguration : ResourceTypeBuilder<PatreonReward>
    {
        public PatreonRewardConfiguration()
        {
            this.ResourceIdentity(x => x.Id).SetApiType("reward");
        }
    }
}