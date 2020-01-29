using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Checkout_Model
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Max 20 char allowed")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Max 20 char allowed")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Max 30 char allowed")]
        public string CompanyName { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Max 30 char allowed")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Wrong email pattern")]
        public string Email { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Max 30 char allowed")]
        public string Address { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Max 30 char allowed")]
        public string Town { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "Max 15 char allowed")]
        public string Zipcode { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "Max 15 char allowed")]
        public int ContactNumber { get; set; }
        
    }
}