using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OutdoorPlanner.Models.Enum
{
    public enum Category
    {
        Concerts,
        Festivals,
        [Display(Name = "Food Festival")]
        FoodFestivals,
        Others
    }
}
