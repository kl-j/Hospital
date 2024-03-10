using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class Doctor
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Cedula Profesional")]
        [MaxLength(10, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public int? RMedicalLicense { get; set; }
        [Required]
        [Display(Name = "Fotografía")]
        //[DataType(DataType.ImageUrl)]
        public string? PhotoUrl { get; set; }
        [Required]
        [Display(Name = "Especialidad")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Specialty { get; set; }


        public User? User { get; set; }
        [Required]

    }
}
