using System;
using System.Collections.Generic;

namespace EventLite.Entities
{
    public partial class Subscription
    {
        public int Id { get; set; }
        public int? VisitorId { get; set; }
        public int? EventId { get; set; }

        public Event Event { get; set; }
        public Visitor Visitor { get; set; }
    }
}
