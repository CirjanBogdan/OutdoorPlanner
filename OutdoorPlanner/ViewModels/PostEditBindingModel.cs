using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace OutdoorPlanner.ViewModels
{
    public class PostEditBindingModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int EventId { get; set; }
        public string? Author { get; set; }
        public bool Edited { get; set; } = true;


        [BindNever]
        public EventViewModel? EventViewModel { get; set; }
        [BindNever]
        public string? UserId { get; set; }
        
        
    }
}
