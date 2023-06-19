using System.ComponentModel.DataAnnotations;

namespace ManagementService.Models
{
    public class Instructor
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Subject { get; set; }

    }
}