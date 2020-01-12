using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ekscarMVC.Models.Common
{
    public class City
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Şehir alanı gereklidir!")]
        [StringLength(250, ErrorMessage = "En fazla 250 karakter!")]
        [Display(Name = "Şehir")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Plaka alanı gereklidir!")]
        [StringLength(250, ErrorMessage = "En fazla 250 karakter!")]
        [Display(Name = "Plaka")]
        [DataType(DataType.Text)]
        public string Plate { get; set; }


        [Required]
        public DateTime FirstDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "Aktif")]
        public bool IsActive { get; set; } = true;
        [Required]
        public bool IsDeleted { get; set; } = false;



        public ICollection<Region> Regions { get; set; }
        public ICollection<Maintenance.Maintenance> Maintenance { get; set; }

    }
}
