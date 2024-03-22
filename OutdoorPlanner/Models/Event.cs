using OutdoorPlanner.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OutdoorPlanner.Models
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "The name of the event is mandatory")]
        public string? Name { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public RomaniaCity City { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; }
        public int Temperature {  get; set; }

        public bool Rain { get; set; } = false;
        public bool Forcasted { get; set; } = false;
        public int? CloudsValue { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public ICollection<Invitation>? Invitations { get; set; }
    }
}
