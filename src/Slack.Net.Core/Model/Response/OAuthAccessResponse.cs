using Newtonsoft.Json;

namespace Slack.Net.Core.Model.Response
{
    public class OAuthAccessResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}