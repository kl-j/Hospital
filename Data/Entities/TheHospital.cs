using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class TheHospital
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del hospital es requerido")]
        [Display(Name = "Nombre")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? HospitalName { get; set; }

        [Required(ErrorMessage = "La dirección del hospital es requerida")]
        [Display(Name = "Dirección Del Hospital")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Adress { get; set; }

        [Required(ErrorMessage = "El número de teléfono del hospital es requerido")]
        [Display(Name = "Número De Teléfono Del Hospital")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? HospitalPhone { get; set; }

        [Required(ErrorMessage = "La página del hospital es requerida")]
        [Display(Name = "Website")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [DataType(DataType.Url)]
        public string? Website { get; set; }

        [Required]
        public ICollection<Lab>? Labs { get; set; }

        [Required]
        public ICollection<Doctor>? Doctors { get; set; }
    }
}
