using System;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.ViewModels
{
    public class EventsVM
    {
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Location { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public string Time { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [DataType(DataType.Text)]
        public string Status { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Category { get; set; }

    }
}
