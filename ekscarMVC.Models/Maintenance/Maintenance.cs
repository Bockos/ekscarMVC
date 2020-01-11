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

        //Car Properties
        public CarBrand Brand { get; set; }

        public CarModel Model { get; set; }

        public string Year { get; set; }

        public string Fuel { get; set; }

        public string Gear { get; set; }

        public string Description { get; set; }

        //[Required(ErrorMessage = "İl alanı gereklidir!")]
        //[StringLength(250, ErrorMessage = "En fazla 250 karakter!")]
        //[Display(Name = "Kullanıcı Adı")]
        //[DataType(DataType.Text)]
        //public string Username { get; set; }


        //[Required(ErrorMessage = "Bu alan gereklidir!")]
        //[StringLength(250)]
        //[Display(Name = "Şifre")]
        //[DataType(DataType.Password)]
        //[RegularExpression("^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$", ErrorMessage = "8 harf, 1 rakam, 1 büyük harf gereklidir!")]
        //public string Password { get; set; }


        //[NotMapped]
        //[Required(ErrorMessage = "Bu alan gereklidir!")]
        //[StringLength(250)]
        //[Display(Name = "Şifre Tekrar")]
        //[Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
        //[DataType(DataType.Password)]
        //public string ConfirmPassword { get; set; }

        //[Required(ErrorMessage = "Bu alan gereklidir!")]
        //[StringLength(250)]
        //[Display(Name = "E-Mail")]
        //[DataType(DataType.EmailAddress)]
        //public string Mail { get; set; }

        //[NotMapped]
        //[Range(typeof(bool), "true", "true", ErrorMessage = "Lütfen onaylayın!")]
        //public bool TermsAndConditions { get; set; }


        //[StringLength(250)]
        //public string Photo { get; set; }

        //[StringLength(100)]
        //public string RecoveryKey { get; set; }

        //[StringLength(10)]
        //public string IsConfirmed { get; set; }

        //[StringLength(20)]
        //public string LastLoginDate { get; set; }

        //[StringLength(20)]
        //public string FirstDate { get; set; }

        //[StringLength(20)]
        //public string UpdateDate { get; set; }

        //[StringLength(10)]
        //public string IsActive { get; set; }


    }
}
