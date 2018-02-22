using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiDotNetCore.Models.Pocos
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int OrganizerUserId { get; set; }

        public ICollection<User> Attendees { get; set; }
    }
}
