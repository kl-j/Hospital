using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class PatientDetail
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El peso del paciente es requerido")]
        [Display(Name = "Peso del paciente")]
        [MaxLength(60, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public double Weight { get; set; }


        [Required(ErrorMessage = "El grupo sanguineo del paciente es requerido")]
        [Display(Name = "Grupo Sanguineo")]
        [MaxLength(60, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? BloodType { get; set; }


        [Required(ErrorMessage = "Las alergías del paciente son requeridas")]
        [MaxLength(60, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Display(Name = "Alergias")]
        public string? Alergias { get; set; }

        [Required]
        public Patient? Patient { get; set; }

        [Required]
        public ICollection<ImageTaken>? ImagesTaken { get; set; }

        public int PatientId { get; set; }

    }
}
