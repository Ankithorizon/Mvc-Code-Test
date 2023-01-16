using System;
using System.ComponentModel.DataAnnotations;

namespace MvcCodeTestLib
{
    public class LoginData
    {
        [EmailAddress(ErrorMessage ="Invalid Email !")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$", ErrorMessage = "Invalid Email Pattern !")]
        [Required(ErrorMessage = "Email is Required !")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required !")]
        [MinLength(6, ErrorMessage = "Password : Minimum 6 characters"), MaxLength(20, ErrorMessage = "Password : Maximum 20 characters")]
        public string Password { get; set; }
    }
}
