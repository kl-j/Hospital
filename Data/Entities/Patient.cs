using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class Patient
    {
        [Required]
        [Display(Name = "Dirección")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Address { get; set; }
        [Required]
        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Fotografía")]
        //[DataType(DataType.ImageUrl)]
        public string? PhotoUrl { get; set; }

        [Required]
        [Display(Name = "Género")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Gender { get; set; }
    }
}
