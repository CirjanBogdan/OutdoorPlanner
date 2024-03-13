using InvitaTest.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace InvitaTest.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The name of the event is mandatory")]
        public string Name { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
