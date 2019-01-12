﻿namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using System;

    public class ApiLobbyMessage
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
    }
}