using OutdoorPlanner.Models.Enum;
using OutdoorPlanner.Models.Enum;

namespace OutdoorPlanner.ViewModels
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public RomaniaCity City { get; set; }
        public int Temperature { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; }
        public bool Rain { get; set; }
        public bool Forcasted { get; set; }
        public int CloudsValue { get; set; }
    }
}
