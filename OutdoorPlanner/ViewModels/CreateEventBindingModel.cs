using OutdoorPlanner.Models;
using OutdoorPlanner.Models.Enum;
using OutdoorPlanner.Models.Enum;

namespace OutdoorPlanner.ViewModels
{
    public class CreateEventBindingModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public DateTime Date { get; set; }
        public RomaniaCity City { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; }
    }
}
