using System;
using System.Threading.Tasks;
using Slack.Net.Core.Client;

namespace Slack.Net.Core.Test.Client
{
    public class SlackApiTestClient<TRequest, TResponse> : ISlackApiClient<TRequest, TResponse>
    {
        public async Task<TResponse> GetAsync(string method, TRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<TResponse> PostAsync(string method, TRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
