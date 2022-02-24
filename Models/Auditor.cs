using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Models
{
    public class Auditor : UsuarioBase
    {
        [Required]
        [Display(Name = "Matrícula")]
        public string Matricula { get; set; }

    }
}
