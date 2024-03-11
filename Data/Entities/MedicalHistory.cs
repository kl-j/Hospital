using System;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class MedicalHistory
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "La descripcion del Hisotiral Medico es requerido")]
        [Display(Name = "Descripcion")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "La fecha y hora de la creación del historial tomada es requerida")]
        [Display(Name = "Fecha y hora del historial")]
        public DateTime CreationDate { get; set; }

        [Required(ErrorMessage = "La fecha y hora de la ultima actuliazación del historial es requerida")]
        [Display(Name = "Fecha y hora de la ultima actualización historial")]
        public DateTime LastUpdate { get; set; }

        [Required(ErrorMessage = "El peso del paciente es requerido")]
        [Display(Name = "Peso del paciente")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Height { get; set; }

        [Required(ErrorMessage = "El pulso del paciente es requerido")]
        [Display(Name = "Pulso del paciente")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? PulseRate { get; set; }

        [Required(ErrorMessage = "La descripción medica acerca de los padecimientos del paciente es requerida")]
        [Display(Name = "Descripción Medica Padecimientos")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? MedicalCondition { get; set; }

        [Required(ErrorMessage = "La descripción medica acerca de los tratamientos del paciente es requerida")]
        [Display(Name = "Descripción Medica Tratamientos")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? CurrentMedication { get; set; }

        [Required(ErrorMessage = "La descripción medica acerca de las observaciones del paciente es requerida")]
        [Display(Name = "Descripción Medica De Las Observaciones Del Paciente")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? SummaryOfFindings { get; set; }

        [Required]
        public Patient? Patient { get; set; }
        [Required]
        public int PatientId { get; set; } // Foreign key property
    }
}
