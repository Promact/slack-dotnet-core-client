using System.Threading.Tasks;
using Slack.Net.Core.Model.Request;
using Slack.Net.Core.Model.Response;

namespace Slack.Net.Core.Repositories.OAuth
{
    public interface IOAuthRepository
    {
        Task<OAuthAccessResponse> AccessAsync(OAuthAccessRequest request);
        Task<OAuthAccessResponse> AccessAsync(string clientId, string clientSecret, string code, string redirectUri);

    }
}