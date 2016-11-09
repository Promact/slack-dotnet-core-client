using System;
using System.Threading.Tasks;
using Slack.Net.Core.Client;
using Slack.Net.Core.Model.Methods;
using Slack.Net.Core.Model.Request;
using Slack.Net.Core.Model.Response;

namespace Slack.Net.Core.Repositories.Test
{
    public class TestRepository : ITestRepository
    {
        private readonly ISlackApiClient<TestRequest, TestResponse> _slackApiClient;
        private readonly MethodAddress _methodAddress;        
        public TestRepository(ISlackApiClient<TestRequest, TestResponse> slackApiClient)
        {
            _slackApiClient = slackApiClient;
            _methodAddress = new MethodAddress();
        }
        public async Task<TestResponse> TestAsync(TestRequest request)
        {
            return await _slackApiClient.GetAsync(_methodAddress.Api.Test, request);
        }

        public async Task<TestResponse> TestAsync(string foo, string error)
        {
            TestRequest request = new TestRequest();
            request.Error = error;
            request.Foo = foo;
            return await this.TestAsync(request);
        }
    }
}
