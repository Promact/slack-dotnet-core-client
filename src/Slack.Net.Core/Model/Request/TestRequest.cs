using Newtonsoft.Json;

namespace Slack.Net.Core.Model.Request
{
    public class TestRequest
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("foo")]
        public string Foo { get; set; }
    }
}
