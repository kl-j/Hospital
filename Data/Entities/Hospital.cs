using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class Hospital
    {
        [Required]
        [Display(Name = "Ubicación")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Address { get; set; }

        [Required]
        [Display(Name = "Website")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [DataType(DataType.Url)]
        public string? Website { get; set; }
    }
}
