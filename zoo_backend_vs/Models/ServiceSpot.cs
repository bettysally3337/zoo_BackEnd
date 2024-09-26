using System.ComponentModel.DataAnnotations;

namespace zoo_backend_vs.Models
{
    public class ServiceSpot
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string S_Item { get; set; } = string.Empty; 
        [Required]
        public string S_Title { get; set; } = string.Empty;
        public string? S_Meal { get; set; }
        public string? S_Brief { get; set; }

        public string? S_Location { get; set; }

        public string? S_Memo { get; set; }
        [Required]
        public string S_Pic01_URL { get; set; } = string.Empty;
    }
}
