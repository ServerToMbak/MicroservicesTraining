using System.ComponentModel.DataAnnotations;

namespace ManagementService.Dtos
{
    public class ClassCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Population { get; set; }
    }

}