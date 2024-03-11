using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class User:IdentityUser
    {
        [Required]
        [Display(Name = "Nombre(s)")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]

        public string? FirstName { get; set; }
        [Display(Name = "Apellidos(s)")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Required]
        public string? LastName { get; set; }

        //[Required]
        //[Display(Name = "Teléfono")]
        //[MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]

        ///REVISAR PHONE
        //public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }



    }
}
