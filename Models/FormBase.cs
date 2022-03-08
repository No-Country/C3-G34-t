using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Models
{
    public class FormBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID de Formulario")]
        public int FormID { get; set; }

        [Required]
        public Guid AuditorGuId { get; set; }
        
        [Required]
        [Display(Name = "Fecha de Auditoría")]
        public DateTime Fecha { get; set; }
        
        public string Observaciones { get; set; }

        [Display(Name = "Responsable del Desvío")]
        public string ResponsableDesvio{ get; set; }

        [Required]
        public int PlantaId { get; set; }
      
    }
}
