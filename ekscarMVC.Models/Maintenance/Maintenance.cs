﻿using ekscarMVC.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekscarMVC.Models.Maintenance
{
    public class Maintenance
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "İl")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "İlçe")]
        public int RegionId { get; set; }

        //Car Properties
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

        public string Description { get; set; }


        public CarBrand Brand { get; set; }
        public CarModel Model { get; set; }
        public CarType Type { get; set; }
        public CarGearType Gear { get; set; }
        public CarFuelType Fuel { get; set; }
        public City City { get; set; }
        public Region Region { get; set; }

    }
}
