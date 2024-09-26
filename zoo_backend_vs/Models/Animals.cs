// Models/Animals.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MyBackend.Models
{
    // [EntityTypeConfiguration(typeof(AnimalsConfiguration))]
    [Table("animals")]
    public class Animals
    {
        [Key]
        public int idx { get; set; }

        [Required]
        [MaxLength(50)]
        public string A_Name_Ch { get; set; }

        [Required]
        [MaxLength(50)]
        public string A_Summary { get; set; }
        
        [Required]
        [MaxLength(1024)]
        public string A_Keywords { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_AlsoKnown { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Geo { get; set; }
        
        [Required]
        [MaxLength(128)]
        public string A_Location { get; set; }
        [Required]
        [MaxLength(50)]
        public string A_POIGroup { get; set; }
        [Required]
        [MaxLength(50)]
        public string A_Name_En { get; set; }
        [Required]
        [MaxLength(50)]
        public string A_Name_Latin { get; set; }
        
        [Required]
        [MaxLength(2048)]
        public string A_Phylum { get; set; }
        [Required]
        [MaxLength(3200)]
        public string A_Class { get; set; }
        [Required]
        [MaxLength(2048)]
        public string A_Order { get; set; }
        [Required]
        [MaxLength(2048)]
        public string A_Family { get; set; }
        
        [Required]
        [MaxLength(2048)]
        public string A_Conservation { get; set; }
        [Required]
        [MaxLength(2048)]
        public string A_Distribution { get; set; }
        [Required]
        [MaxLength(2048)]
        public string A_Habitat { get; set; }
        [Required]
        [MaxLength(1024)]
        public string A_Feature { get; set; }
        
        [Required]
        [MaxLength(3000)]
        public string A_Behavior { get; set; }
        [Required]
        [MaxLength(1024)]
        public string A_Diet { get; set; }
        [Required]
        [MaxLength(2048)]
        public string A_Crisis { get; set; }   
        [Required]
        [MaxLength(512)]
        public string A_Interpretation { get; set; }

        [Required]
        [MaxLength(128)]
        public string A_Theme_Name { get; set; }

        [Required]
        [MaxLength(128)]
        public string A_Theme_URL { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Adopt { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Code { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Pic01_ALT { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Pic01_URL { get; set; }

        [Required]
        [MaxLength(128)]
        public string A_Pic02_ALT { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Pic02_URL { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Pic03_ALT { get; set; }
        [Required]
        [MaxLength(128)] 
        public string A_Pic03_URL { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Pic04_ALT { get; set; }

        [Required]
        [MaxLength(128)]
        public string A_Pic04_URL { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_pdf01_ALT { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_pdf01_URL { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_pdf02_ALT { get; set; }

        [Required]
        [MaxLength(128)]
        public string A_pdf02_URL { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Voice01_ALT { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Voice01_URL { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Voice02_ALT { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Voice02_URL { get; set; }
        [Required]
        [MaxLength(128)]
        public string A_Voice03_ALT { get; set; }

        [Required]
        [MaxLength(128)]
        public string A_Vedio_URL { get; set; }
        
        [MaxLength(128)]
        public string? A_Update { get; set; }
        
        [MaxLength(128)]
        public string? A_CID { get; set; }
      

    }
}