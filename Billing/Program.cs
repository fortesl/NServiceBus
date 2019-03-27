using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Threading.Tasks;

namespace Billing
{
    class Program
    {
        static ILog log = LogManager.GetLogger("Billing");

        static async Task Main()
        {
            Console.Title = "Billing";

            var endpointConfiguration = new EndpointConfiguration("Billing");
            var transport = endpointConfiguration.UseTransport<LearningTransport>();

            var endpointInstance = await Endpoint
                .Start(endpointConfiguration)
                .ConfigureAwait(false);

            log.Info("Press a key to exit");
            Console.ReadLine();

            await endpointInstance.Stop().ConfigureAwait(false);
        }

    }
}
