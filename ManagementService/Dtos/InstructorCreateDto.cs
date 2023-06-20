using System.ComponentModel.DataAnnotations;

namespace ManagementService.Dtos
{
    public class InstructorCreateDto
    {
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}