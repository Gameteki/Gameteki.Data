﻿namespace CrimsonDev.Gameteki.Data.Models.Config
{
    public class GametekiApiOptions
    {
        public string DatabaseProvider { get; set; }
        public string ApplicationName { get; set; }
        public string RedisUrl { get; set; }
        public string ImagePath { get; set; }
        public bool AccountVerification { get; set; }
    }
}