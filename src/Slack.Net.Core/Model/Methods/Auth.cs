namespace Slack.Net.Core.Model.Methods
{
    public class Auth
    {
        public string Revoke { get; private set; } = "auth.revoke";
        public string Test { get; private set; } = "auth.test";        
    }
}