using Message.Events;
using System;
using NServiceBus;
using System.Text;
using System.Threading.Tasks;
using NServiceBus.Logging;

namespace Shipping.Handlers
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        static ILog log = LogManager.GetLogger("Billing");

        public Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderPlaced event orderId: {message.OrderId} -- Shipping order");

            return Task.CompletedTask;
        }
    }
}
