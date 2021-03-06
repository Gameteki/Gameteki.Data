﻿namespace CrimsonDev.Gameteki.Data.Models
{
    using System;

    public class LobbyMessage
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public int SenderId { get; set; }
        public DateTime MessageDateTime { get; set; }
        public bool Removed { get; set; }
        public int RemovedById { get; set; }
        public DateTime RemovedDateTime { get; set; }

        public virtual GametekiUser Sender { get; set; }
        public virtual GametekiUser RemovedBy { get; set; }
    }
}
