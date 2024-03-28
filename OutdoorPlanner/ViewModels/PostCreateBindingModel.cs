using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace OutdoorPlanner.ViewModels
{
    public class PostCreateBindingModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter content.")]
        public string Content { get; set; }
        public string? UserId { get; set; }
        public string? Author { get; set; }
        public int EventId { get; set; }
        
        [BindNever]
        public EventViewModel? EventViewModel { get; set; }
    }
}
