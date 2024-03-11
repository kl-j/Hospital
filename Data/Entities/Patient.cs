using System;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class Patient
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del paciente es requerido")]
        [Display(Name = "Nombre Del Paciente")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? FirstNameP { get; set; }

        [Required(ErrorMessage = "El apellido del paciente es requerido")]
        [Display(Name = "Apellido Del Paciente")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? LastNameP { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento del paciente es requerida")]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "El género del paciente es requerido")]
        [Display(Name = "Género")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "La dirección del paciente es requerida")]
        [Display(Name = "Dirección")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? AdressP { get; set; }

        [Required(ErrorMessage = "El número de teléfono del paciente es requerido")]
        [Phone(ErrorMessage = "Número de teléfono inválido")]
        [Display(Name = "Teléfono")]
        public string? PhoneNumberP { get; set; }

        [Required(ErrorMessage = "El correo electrónico del paciente es requerido")]
        [Display(Name = "Correo electrónico")]
        [MaxLength(200, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? EmailAdressP { get; set; }

        [Required(ErrorMessage = "La página del hospital es requerida")]
        [Display(Name = "Fotografía Del Doctor")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [DataType(DataType.Url)]
        public string? PhotoP { get; set; }

        [Required]
        public MedicalHistory? MedicalHistory { get; set; }

        [Required]
        public PatientDetail? PatientDetails { get; set; }

        [Required]
        public User? User { get; set; }
        public int MedicalHistoryId { get; set; } // Foreign key property
        public int PatientDetailId { get; set; }
    }
}
