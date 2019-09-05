using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ekscarMVC.Models
{
    public class Users
    {

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username can not be empty!")]
        [StringLength(250, ErrorMessage = "Max 250 character!")]
        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password can not be empty!")]
        [StringLength(250)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$", ErrorMessage = "At least 1 uppercase, 1 digit, min 8 char!")]
        public string Password { get; set; }


        [NotMapped]
        [Required(ErrorMessage = "Password can not be empty!")]
        [StringLength(250)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password does not match!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email can not be empty!")]
        [StringLength(250)]
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [NotMapped]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You gotta tick the box!")]
        public bool TermsAndConditions { get; set; }


        [StringLength(250)]
        public string Photo { get; set; }

        [StringLength(100)]
        public string RecoveryKey { get; set; }

        [StringLength(10)]
        public string IsConfirmed { get; set; }

        [StringLength(20)]
        public string LastLoginDate { get; set; }

        [StringLength(20)]
        public string FirstDate { get; set; }

        [StringLength(20)]
        public string UpdateDate { get; set; }

        [StringLength(10)]
        public string IsActive { get; set; }



    }
}