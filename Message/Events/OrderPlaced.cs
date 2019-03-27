using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Message.Events
{
    public class OrderPlaced : IEvent
    {
        public string OrderId { get; set; }
    }
}
