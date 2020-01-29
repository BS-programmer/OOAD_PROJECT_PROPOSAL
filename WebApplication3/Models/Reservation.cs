using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    [Table("tblReg")]
    public class Reservation
    {
        [Key]
        public int sid { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        public string Name { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Max 20 char allowed")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Wrong email pattern")]
        public string Email { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        public string Guide { get; set; }
        public string Offers { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        public string Service { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "Max 15 char allowed")]
        public string cellNo { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "Max 15 char allowed")]
        public string NIC { get; set; }
    }

    [Table("TblPayment")]
    public class Payment
    {
        public int id { get; set; }
        public string paymentMode { get; set; }
        public virtual Reservation Reservation { get; set; }
        public int RegId { get; set; }
    }
    [Table("TblPackage")]
    public class Pkg
    {
        public int id { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        public string Offer { get; set; }
        public string Image { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Max 100 char allowed")]
        public string Description { get; set; }
    }
    [Table("TblServices")]
    public class Services
    {
        public int id { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        public string Service { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        public string Image { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Max 100 char allowed")]
        public string Description { get; set; }
    }
//    [Table("TblLogin")]
//}
    //public class Login
    //{
    //    public int id { get; set; }
    //    [Required]
    //    [MaxLength(20, ErrorMessage = "Max 20 char allowed")]
    //    [DataType(DataType.EmailAddress, ErrorMessage = "Wrong email pattern")]
    //    [Display(Name="Email Address")]
    //    public string Email { get; set; }
    //    [Required]
    //    [DataType(DataType.Password)]
    //    [MaxLength(15, ErrorMessage = "Max 15 char allow")]
    //    [MinLength(5, ErrorMessage = "Min 5 char alow")]
    //    public string Password { get; set; }
    //}

}