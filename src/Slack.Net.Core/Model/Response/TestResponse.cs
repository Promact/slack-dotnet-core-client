using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Slack.Net.Core.Model.Response
{
    public class TestResponse : ResponseBase
    {
        [JsonProperty("args")]
        public Args Args{ get; set; }
    }
}
