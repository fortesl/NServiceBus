using Message.Events;
using System;
using NServiceBus;
using System.Text;
using System.Threading.Tasks;
using NServiceBus.Logging;

namespace Billing.Handlers
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        static ILog log = LogManager.GetLogger("Billing");

        public Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderPlaced event orderId: {message.OrderId} -- Charging credit card");

            log.Info($"Publishing OrderBilled event orderId: {message.OrderId}");

            return context.Publish(new OrderBilled { OrderId = message.OrderId });
        }
    }
}
