namespace CrimsonDev.Gameteki.Data.Models
{
    using CrimsonDev.Gameteki.Data.Models.Patreon;
    using JsonApiFramework.ServiceModel.Configuration;

    public class PatreonPledgeConfiguration : ResourceTypeBuilder<PatreonPledge>
    {
        public PatreonPledgeConfiguration()
        {
            this.ResourceIdentity(x => x.Id).SetApiType("pledge");
            ToOneRelationship<PatreonUser>("creator");
        }
    }
}