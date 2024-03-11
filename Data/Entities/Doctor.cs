using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class Doctor
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del doctor es requerido")]
        [Display(Name = "Nombre(s)")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "El apellido del doctor es requerido")]
        [Display(Name = "Apellidos")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "La especialidad del doctor es requerida")]
        [Display(Name = "Especialidad")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Especialidad { get; set; }

        [Required(ErrorMessage = "El número de teléfono del doctor es requerido")]
        [Display(Name = "Número De Celular")]
        [MaxLength(30, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "El correo electrónico del doctor es requerido")]
        [Display(Name = "Correo Electronico")]
        [MaxLength(30, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? EmailAdress { get; set; }

        [Required(ErrorMessage = "La licencia medica del doctor es requerido")]
        [Display(Name = "Licencia Medica")]
        [MaxLength(30, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? MedicalLicense { get; set; }

        [Required(ErrorMessage = "La página del hospital es requerida")]
        [Display(Name = "Fotografía Del Doctor")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [DataType(DataType.Url)]
        public string? PhotoM { get; set; }
        public ICollection<Patient>? Patients { get; set; }

        [Required]
        public User? User { get; set; }

    }
}
