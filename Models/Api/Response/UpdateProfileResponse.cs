﻿namespace CrimsonDev.Gameteki.Data.Models.Api
{
    public class UpdateProfileResponse : ApiResponse
    {
        public ApiUser User { get; set; }
        public RefreshToken Token { get; set; }
    }
}