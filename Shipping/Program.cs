using System;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;

namespace Shipping
{
    class Program
    {
        static ILog log = LogManager.GetLogger("Shipping");

        static async Task Main()
        {
            Console.Title = "Shipping";

            var endpointConfiguration = new EndpointConfiguration("Shipping");
            var transport = endpointConfiguration.UseTransport<LearningTransport>();

            var endpointInstance = await Endpoint.Start(endpointConfiguration).ConfigureAwait(false);

            log.Info("Press a key to exit");

            Console.ReadLine();

            await endpointInstance.Stop().ConfigureAwait(false);
        }
    }
}
