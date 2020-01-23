﻿namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public class UpdateProfileRequest
    {
        [Required]
        public string Email { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string CustomData { get; set; }
        [Required]
        public ApiSettings Settings { get; set; }
        [JsonConverter(typeof(Base64FileConverter))]
        public byte[] Avatar { get; }
    }
}
