using System;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class Events
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Attendees { get; set; }
    }
}
