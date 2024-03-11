using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class Lab
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del laboratorio es requerido")]
        [Display(Name = "Nombre Del Laboratorio")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? LabName { get; set; }

        [Required(ErrorMessage = "La dirección del laboratorio es requerida")]
        [Display(Name = "Dirección Del Laboratorio")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "El número de teléfono del laboratorio es requerido")]
        [Phone(ErrorMessage = "Número de teléfono inválido")]
        [Display(Name = "Teléfono Del Laboratorio")]
        public string? LabPhone { get; set; }

        [Required(ErrorMessage = "La fecha y hora del Documento es requerido")]
        [Display(Name = "Fecha y hora del documento")]
        public DateTime? DateHourLab { get; set; }

        [Required(ErrorMessage = "El código del documento es requerido")]
        [Display(Name = "Codigo Del Documento")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? LabFile { get; set; }
    }
}
