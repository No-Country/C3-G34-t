using System.ComponentModel.DataAnnotations;

namespace MaxionMontichV2.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "La Nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Email es obligatorio")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La Contraseña es obligatorio")]
        [Display(Name = "Contraseña")]
        public string Contraseña { get; set; }

        public string Rol { get; set; }

        public bool State { get; set; }
    }
}
