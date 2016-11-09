using Newtonsoft.Json;

namespace Slack.Net.Core.Model.Request
{
    public class OAuthAccessRequest
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }
    }
}