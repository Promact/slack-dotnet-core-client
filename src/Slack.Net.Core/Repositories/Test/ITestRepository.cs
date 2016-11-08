using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slack.Net.Core.Model.Request;
using Slack.Net.Core.Model.Response;

namespace Slack.Net.Core.Repositories.Test
{
    public interface ITestRepository
    {
        Task<TestResponse> TestAsync(TestRequest request);
    }
}
