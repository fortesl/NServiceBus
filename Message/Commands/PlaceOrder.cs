using NServiceBus;

namespace Message.Commands
{
    public class PlaceOrder : ICommand
    {
        public string OrderId { get; set; }
    }
}
