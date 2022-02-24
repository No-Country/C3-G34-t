using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Models
{
    public class UsuarioBase : IdentityUser
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; } */

        [Required]
        public string UserFirstName { get; set; }

        [Required]
        public string UserLastName { get; set; }

        
        [Required(ErrorMessage = "Ingresar sólo números.Campo obligatorio")]
        [StringLength(8, MinimumLength = 8)]

        public string DNI { get; set; }

        // ID, nombre, email, numero de teléfono se heredan de IdentityUser, el IdRol también lo heredaría pero no lo hemos implementado (se verá en su momento)
    }
}
