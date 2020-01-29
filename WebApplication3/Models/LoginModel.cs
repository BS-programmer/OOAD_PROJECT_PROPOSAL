using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WebApplication3.Manager;
using WebApplication3.Models;
using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{
    public class LoginModel
    {
        [Required]
       
        public int ID { get; set; }
        [Required(ErrorMessage ="Invalid Email address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Wrong email pattern")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Please must enter password")]
        [MaxLength(20, ErrorMessage = "Max 15 char allowed")]
        public  string Password { get; set;}

       public int type { get;set; }
    }
}