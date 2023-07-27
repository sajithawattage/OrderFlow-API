using System.Text.Json.Serialization;

namespace OrderFlow.Api.ViewModels
{
    public class LoginRequestViewModel
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class LoginResponseViewModel
    {
        public string token { get; set; }
        public bool isError { get; set; } = false;
        public string message { get; set; }
        public Claims body { get; set; }
    }

    public class Claims
    {
        [JsonPropertyName("UserId")]
        public int UserId { get; set; }

        [JsonPropertyName("UserName")]
        public string UserName { get; set; }

        [JsonPropertyName("UserLevel")]
        public int? UserLevel { get; set; }

        [JsonPropertyName("RepCode")]
        public int? RepCode { get; set; }

        [JsonPropertyName("AreaCode")]
        public string AreaCode { get; set; }

        [JsonPropertyName("Active")]
        public bool Active { get; set; }
    }

}
