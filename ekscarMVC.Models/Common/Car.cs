using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ekscarMVC.Models.Common
{
    public class Car
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "Marka")]
        public int BrandId { get; set; }

        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "Model")]
        public int ModelId { get; set; }

        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "Tür")]
        public int TypeId { get; set; }

        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "Yıl")]
        public string Year { get; set; }

       [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "Vites")]
        public int GearId { get; set; }

        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "Yakıt")]
        public int FuelId { get; set; }

        [Required]
        public DateTime FirstDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "Aktif")]
        public bool IsActive { get; set; } = true;
        [Required]
        public bool IsDeleted { get; set; } = false;


        public CarBrand Brand { get; set; }
        public CarModel Model { get; set; }
        public CarType Type { get; set; }
        public CarGearType Gear { get; set; }
        public CarFuelType Fuel { get; set; }


    }
}
