using System.ComponentModel.DataAnnotations;

namespace ManagementService.Models
{
    public class Class
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Population { get; set; }

    }
}