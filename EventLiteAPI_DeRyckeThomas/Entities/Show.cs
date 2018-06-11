using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventLite.Entities
{
    public partial class Show
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH:MM}")]
        public DateTime Start { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH:MM}")]
        public DateTime End { get; set; }
        public int? TypeId { get; set; }
        public int? EventId { get; set; }
        public string Performer { get; set; }

        public Event Event { get; set; }
        public ShowType Type { get; set; }
    }
}
