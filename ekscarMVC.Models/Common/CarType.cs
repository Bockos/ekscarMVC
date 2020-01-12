using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekscarMVC.Models.Common
{
    public class CarType
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan gereklidir")]
        [StringLength(250, ErrorMessage = "En fazla 250 karakter!")]
        [Display(Name = "Araç Tipi")]
        [DataType(DataType.Text)]
        public string Name { get; set; }


        [Required]
        public DateTime FirstDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "Aktif")]
        public bool IsActive { get; set; } = true;
        [Required]
        public bool IsDeleted { get; set; } = false;

        public ICollection<Maintenance.Maintenance> Maintenance { get; set; }


    }
}
