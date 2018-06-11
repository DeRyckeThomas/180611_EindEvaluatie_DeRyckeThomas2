using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventLite.Entities
{
    public partial class Event
    {
        public Event()
        {
            Show = new HashSet<Show>();
            Subscription = new HashSet<Subscription>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? VenueId { get; set; }
        public int? CategoryId { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Start { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime End { get; set; }
        public decimal Price { get; set; }

        public Category Category { get; set; }
        public Venue Venue { get; set; }
        public ICollection<Show> Show { get; set; }
        public ICollection<Subscription> Subscription { get; set; }
    }
}
