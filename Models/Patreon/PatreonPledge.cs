namespace CrimsonDev.Gameteki.Data.Models.Patreon
{
    using System;

    public class PatreonPledge
    {
        public string Id { get; set; }
        public int AmountCents { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeclinedSince { get; set; }
        public int PledgeCapCents { get; set; }
        public bool PatronPaysFees { get; set; }
        public int TotalHistoricalAmountCents { get; set; }
        public bool IsPaused { get; set; }
        public bool HasShippingAddress { get; set; }
    }
}
