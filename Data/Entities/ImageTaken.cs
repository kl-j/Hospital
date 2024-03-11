using System;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class ImageTaken
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "La ruta de la imagen es requerida")]
        [Display(Name = "Ruta de la imagen")]
        [DataType(DataType.ImageUrl)]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "La descripcion es requerida")]
        [Display(Name = "Descripción")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Description{ get; set; }

        [Required(ErrorMessage = "La fecha y hora de la imagen tomada es requerida")]
        [Display(Name = "Fecha y hora de la imagen tomada")]
        public DateTime DateHour { get; set; }


        public int Paciente { get; set; }
    }
}

