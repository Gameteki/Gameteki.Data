namespace CrimsonDev.Gameteki.Data.Models
{
    using System;
    using CrimsonDev.Gameteki.Data.Models.Patreon;
    using JsonApiFramework.ServiceModel.Configuration;

    public class PatreonPledgeConfiguration : ResourceTypeBuilder<PatreonPledge>
    {
        public PatreonPledgeConfiguration()
        {
            this.ResourceIdentity(x => x.Id).SetApiType("pledge");
            ToOneRelationship<PatreonUser>("creator");
            ToOneRelationship<PatreonReward>("reward");
            ToOneRelationship<PatreonUser>("patron");

            this.Attribute(p => p.AmountCents).SetApiPropertyName("amount_cents");
            this.Attribute(p => p.CreatedAt).SetApiPropertyName("created_at");
            this.Attribute(p => p.DeclinedSince).SetApiPropertyName("declined_since");
            this.Attribute(p => p.IsPaused).SetApiPropertyName("is_paused");
            this.Attribute(p => p.HasShippingAddress).SetApiPropertyName("has_shipping_address");
            this.Attribute(p => p.PatronPaysFees).SetApiPropertyName("patron_pays_fees");
            this.Attribute(p => p.PledgeCapCents).SetApiPropertyName("pledge_cap_cents");
            this.Attribute(p => p.TotalHistoricalAmountCents).SetApiPropertyName("total_historical_amount_cents");
        }
    }
}
