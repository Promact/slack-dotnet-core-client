using System.Threading.Tasks;

namespace Slack.Net.Core.Client
{
    public interface ISlackApiClient<TRequest,TResponse>
    {
        Task<TResponse> GetAsync(string method,TRequest request);
        Task<TResponse> PostAsync(string method, TRequest request);
    }
}