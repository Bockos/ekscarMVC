using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekscarMVC.Models
{
    public class CarModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "İlçe alanı gereklidir!")]
        [StringLength(250, ErrorMessage = "En fazla 250 karakter!")]
        [Display(Name = "İlçe")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        public CarBrand CarBrand { get; set; }

        public int CarBrandId { get; set; }

    }
}
