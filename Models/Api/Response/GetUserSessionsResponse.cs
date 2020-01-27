namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using System.Collections.Generic;

    public class GetUserSessionsResponse : ApiResponse
    {
        public List<ApiToken> Tokens { get; } = new List<ApiToken>();
    }
}