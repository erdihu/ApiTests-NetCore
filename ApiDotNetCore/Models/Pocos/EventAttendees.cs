using System.ComponentModel.DataAnnotations;

namespace ApiDotNetCore.Models.Pocos
{
    public class EventAttendees
    {
        [Key]
        public int Id { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public string SelectedFood { get; set; }

    }
}
