using System.Threading.Tasks;

namespace Slack.Net.Core.Client
{
    public interface ISlackApiClient<TRequest,TResponse>
    {
        Task<TResponse> GetAsync(string module,string method,TRequest request);
        Task<TResponse> PostAsync(string module, string method, TRequest request);
    }
}