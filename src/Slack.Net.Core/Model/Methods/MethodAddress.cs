using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slack.Net.Core.Model.Methods
{
    public class MethodAddress
    {
        public Api Api { get; set; }
        public Auth Auth { get; set; }
        public Bots Bots { get; set; }
        public Groups Groups { get; set; }
        public Chat Chat { get; set; }
        public OAuth OAuth { get; set; }
        public Channels Channels { get; set; }
    }
}
