using System.Threading.Tasks;
using Slack.Net.Core.Client;
using Slack.Net.Core.Model.Request;
using Slack.Net.Core.Model.Response;

namespace Slack.Net.Core.Repositories.Test
{
    public class TestRepository : ITestRepository
    {
        private readonly ISlackApiClient<TestRequest, TestResponse> _slackApiClient;
        public TestRepository(ISlackApiClient<TestRequest,TestResponse> slackApiClient)
        {
            _slackApiClient = slackApiClient;
        }
        public async Task<TestResponse> TestAsync(TestRequest request)
        {
            return await _slackApiClient.GetAsync("api","test",request);
        }
    }
}
