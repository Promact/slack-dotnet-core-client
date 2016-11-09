using Autofac;
using Slack.Net.Core.Client;
using Slack.Net.Core.Repositories.Test;

namespace Slack.Net.Core.Autofac
{
    public class SlackApiRepositoryRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {            
            builder.RegisterGeneric(typeof(SlackApiV1Client<,>)).As(typeof(ISlackApiClient<,>));
            builder.RegisterType<TestRepository>().As<ITestRepository>();
            base.Load(builder);
        }
    }
}
