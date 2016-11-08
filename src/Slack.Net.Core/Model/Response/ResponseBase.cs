using Newtonsoft.Json;

namespace Slack.Net.Core.Model.Response
{
    public abstract class ResponseBase
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }
        [JsonProperty("warning")]
        public string Warning { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
