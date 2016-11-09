using Autofac;
using Slack.Net.Core.Client;
using Slack.Net.Core.Repositories.Test;
using Slack.Net.Core.Test.Client;

namespace Slack.Net.Core.Test.Autofac
{
    public class SlackApiRepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(SlackApiTestClient<,>)).As(typeof(ISlackApiClient<,>));
            builder.RegisterType<TestRepository>().As<ITestRepository>();
            base.Load(builder);
        }
    }
}
