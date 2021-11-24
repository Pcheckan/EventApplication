using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class Interests
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Name { get; set; }
    }
}
