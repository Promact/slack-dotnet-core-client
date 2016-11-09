using System.Threading.Tasks;
using Slack.Net.Core.Client;
using Slack.Net.Core.Model.Methods;
using Slack.Net.Core.Model.Request;
using Slack.Net.Core.Model.Response;

namespace Slack.Net.Core.Repositories.OAuth
{
    public class OAuthRepository : IOAuthRepository
    {
        private readonly ISlackApiClient<OAuthAccessRequest, OAuthAccessResponse> _slackApiClient;
        private readonly MethodAddress _methodAddress;        
        public OAuthRepository(ISlackApiClient<OAuthAccessRequest,OAuthAccessResponse>  slackApiClient)
        {
            _slackApiClient = slackApiClient;
            _methodAddress = new MethodAddress();
        }
        public async Task<OAuthAccessResponse> AccessAsync(OAuthAccessRequest request)
        {
            return await _slackApiClient.PostAsync(_methodAddress.OAuth.Access, request);
        }
        public async Task<OAuthAccessResponse> AccessAsync(string clientId, string clientSecret, string code, string redirectUri)
        {
            var oauthRequest = new OAuthAccessRequest()
            {
                ClientId = clientId,
                ClientSecret = clientSecret,
                Code = code,
                RedirectUri = redirectUri
            };
            return await this.AccessAsync(oauthRequest);
        }
    }
}