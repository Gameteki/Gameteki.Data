namespace CrimsonDev.Gameteki.Data.Models.Config
{
    public class GametekiApiOptions
    {
        public string DatabaseProvider { get; set; }
        public string ApplicationName { get; set; }
#pragma warning disable CA1056 // Uri properties should not be strings
        public string RedisUrl { get; set; }
#pragma warning restore CA1056 // Uri properties should not be strings
        public string ImagePath { get; set; }
        public bool AccountVerification { get; set; }
    }
}