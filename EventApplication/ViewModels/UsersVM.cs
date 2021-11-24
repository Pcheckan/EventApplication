using System;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.ViewModels
{
    public class UsersVM
    {
        public int? Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string State { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Interest1 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Interest2 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Interest3 { get; set; }


        public bool RememberMe { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
