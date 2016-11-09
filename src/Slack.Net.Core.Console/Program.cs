using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slack.Net.Core.Client;
using Slack.Net.Core.Model.Request;
using Slack.Net.Core.Model.Response;
using Slack.Net.Core.Repositories.Test;

namespace Slack.Net.Core.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISlackApiClient<TestRequest, TestResponse> repository = new SlackApiV1Client<TestRequest, TestResponse>();
            ITestRepository test = new TestRepository(repository);
            var result = test.TestAsync(new TestRequest() { Error = "my test error", Foo = "boooo" }).Result;
            System.Console.WriteLine("Done");            
        }
    }
}
