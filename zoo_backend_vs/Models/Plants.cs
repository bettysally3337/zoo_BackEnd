// Models/Plants.cs
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace zoo_backend_vs.Models
{
    [Table("plants")]
    public class Plants
    {
        [Key]
        public int idx { get; set; }

        [Required]
        [MaxLength(50)]
        public string F_Name_Ch { get; set; }

        [MaxLength(50)]
        public string F_Summary { get; set; }

        [MaxLength(50)]
        public string F_Keywords { get; set; }

        [Required]
        [MaxLength(120)]
        public string F_AlsoKnown { get; set; }

        [MaxLength(1024)]
        public string F_Geo { get; set; }

        [Required]
        [MaxLength(512)]
        public string F_Location { get; set; }

        [Required]
        [MaxLength(256)]
        public string F_Name_En { get; set; }

        [Required]
        [MaxLength(128)]
        public string F_Name_Latin { get; set; }

        [Required]
        [MaxLength(50)]
        public string F_Family { get; set; }

        [Required]
        [MaxLength(50)]
        public string F_Genus { get; set; }

        [Required]
        [MaxLength(512)]
        public string F_Brief { get; set; }

        [Required]
        [MaxLength(550)]
        public string F_Feature { get; set; }

        [Required]
        [MaxLength(512)]
        public string F_Function_Application { get; set; }

        [MaxLength(50)]
        public string F_Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string F_Pic01_ALT { get; set; }

        [Required]
        [MaxLength(512)]
        public string F_Pic01_URL { get; set; }

        [Required]
        [MaxLength(50)]
        public string F_Pic02_ALT { get; set; }

        [Required]
        [MaxLength(512)]
        public string F_Pic02_URL { get; set; }

        [MaxLength(50)]
        public string F_Pic03_ALT { get; set; }

        [MaxLength(512)]
        public string F_Pic03_URL { get; set; }

        [MaxLength(50)]
        public string F_Pic04_ALT { get; set; }

        [MaxLength(512)]
        public string F_Pic04_URL { get; set; }

        [MaxLength(50)]
        public string F_pdf01_ALT { get; set; }

        [MaxLength(512)]
        public string F_pdf01_URL { get; set; }

        [MaxLength(50)]
        public string F_pdf02_ALT { get; set; }

        [MaxLength(512)]
        public string F_pdf02_URL { get; set; }

        [MaxLength(50)]
        public string F_Voice01_ALT { get; set; }

        [MaxLength(512)]
        public string F_Voice01_URL { get; set; }

        [MaxLength(50)]
        public string F_Voice02_ALT { get; set; }

        [MaxLength(512)]
        public string F_Voice02_URL { get; set; }

        [MaxLength(50)]
        public string F_Voice03_ALT { get; set; }

        [MaxLength(512)]
        public string F_Voice03_URL { get; set; }


        [MaxLength(512)]
        public string F_Vedio_URL { get; set; }

        [Required]
        [MaxLength(50)]
        public string F_Update { get; set; }

        [Required]
        [MaxLength(50)]
        public string F_CID { get; set; }

    }
}
