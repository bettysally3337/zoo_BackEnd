// Models/Area.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

namespace zoo_backend_vs.Models
{
    [Table("area")]
    public class Area
    {
        [Key]
        public string E_no { get; set; }

        [Required]
        [MaxLength(20)]
        public string E_Category { get; set; }

        [Required]
        [MaxLength(64)]
        public string E_Name { get; set; }

        [MaxLength(64)]
        public string E_Pic_URL { get; set; }

        [Required]
        [MaxLength(1500)]
        public string E_Info { get; set; }

        [Required]
        [MaxLength(128)]
        public string E_Memo { get; set; }

        [MaxLength(128)]
        public string E_Geo { get; set; }

        [Required]
        [MaxLength(128)]
        public string E_URL { get; set; }
    }
}
