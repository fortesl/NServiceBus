using System;
using NServiceBus;
using NServiceBus.Logging;
using System.Text;
using Message.Events;
using System.Threading.Tasks;

namespace Shipping.Handlers
{
    class OrderBilledHandler : IHandleMessages<OrderBilled>
    {
        static ILog log = LogManager.GetLogger("Shipping");

        public Task Handle(OrderBilled message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderBilled Event for OrderId: {message.OrderId} -- Shipping order...");

            return Task.CompletedTask;
        }
    }
}
