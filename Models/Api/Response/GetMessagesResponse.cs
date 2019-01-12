namespace CrimsonDev.Gameteki.Data.Models.Api
{
    using System.Collections.Generic;

    public class GetMessagesResponse : ApiResponse
    {
        public List<ApiLobbyMessage> Messages { get; set; }
    }
}
