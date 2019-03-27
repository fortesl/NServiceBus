using System.Threading.Tasks;
using Message.Commands;
using Message.Events;
using NServiceBus;
using NServiceBus.Logging;

namespace Sales.Handlers
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        static ILog log = LogManager.GetLogger("Sales");

        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            log.Info($"Received Order, OrderId: {message.OrderId}");

            log.Info($"Publish Order Placed event {message.OrderId}");

            var orderPlaced = new OrderPlaced { OrderId = message.OrderId };

            return context.Publish(orderPlaced);
        }
    }
}
