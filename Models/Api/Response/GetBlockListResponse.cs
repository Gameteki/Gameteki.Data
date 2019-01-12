namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using System.Collections.Generic;

    public class GetBlockListResponse : ApiResponse
    {
        public List<string> BlockList { get; set; }
    }
}