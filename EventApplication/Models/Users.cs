using System;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOB { get; set; }
        public string Interest1 { get; set; }
        public string Interest2 { get; set; }
        public string Interest3 { get; set; }
    }
}
