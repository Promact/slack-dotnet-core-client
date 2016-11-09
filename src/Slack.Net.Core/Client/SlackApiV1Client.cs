using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Slack.Net.Core.Helpers;

namespace Slack.Net.Core.Client
{
    public class SlackApiV1Client<TRequest, TResponse> : ISlackApiClient<TRequest, TResponse>
    {
        private readonly string SlackApiBase = "https://slack.com/api/{0}";
        public async Task<TResponse> GetAsync(string method, TRequest request)
        {
            using (HttpClient client = new HttpClient())
            {
                var queryString = request.ToQueryString();
                var httpMessage = await client.GetAsync(string.Format(SlackApiBase, method) + "?" + queryString);
                using (httpMessage)
                using (TextReader textReader = new StringReader(await httpMessage.Content.ReadAsStringAsync()))
                using (JsonReader reader = new JsonTextReader(textReader))
                {
                    return JsonSerializer.Create().Deserialize<TResponse>(reader);
                }
            }
        }

        public async Task<TResponse> PostAsync(string method, TRequest request)
        {
            var jsonSerializer = JsonSerializer.Create();
            using (HttpClient client = new HttpClient())
            using (StringWriter textWriter = new StringWriter())
            using (JsonWriter writer = new JsonTextWriter(textWriter))
            {
                jsonSerializer.Serialize(writer, request);
                var httpMessage = await client.PostAsync(string.Format(SlackApiBase, method), new StringContent(textWriter.GetStringBuilder().ToString()));
                using (httpMessage)
                using (TextReader textReader = new StringReader(await httpMessage.Content.ReadAsStringAsync()))
                using (JsonReader reader = new JsonTextReader(textReader))
                {
                    return jsonSerializer.Deserialize<TResponse>(reader);
                }
            }
        }
    }
}