namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using System.Collections.Generic;

    public class GetNewsResponse : ApiResponse
    {
        public List<News> News { get; } = new List<News>();
    }
}