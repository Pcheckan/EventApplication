using System;
using System.ComponentModel.DataAnnotations;
namespace EventApplication.ViewModels
{
    public class SearchVM
    {
        [Required]
        [DataType(DataType.Text)]
        public string Category { get; set; }
    }
}
