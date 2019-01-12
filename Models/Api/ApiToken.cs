namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using System;

    public class ApiToken
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public DateTime LastUsed { get; set; }
    }
}