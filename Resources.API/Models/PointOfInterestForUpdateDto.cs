using System.ComponentModel.DataAnnotations;

namespace Resources.API.Models
{
    public class PointOfInterestForUpdateDto
    {
        [Required(ErrorMessage = "The name value is required at a maximum length of 50 charactors ")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
