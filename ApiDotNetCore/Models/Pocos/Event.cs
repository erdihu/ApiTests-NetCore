using System;

namespace ApiDotNetCore.Models.Pocos
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
