using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> Developers
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Models
{
    public class FormBase
    {
<<<<<<< HEAD
        public int AuditorId { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public string ResponsableDesvio{ get; set; }
=======
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
>>>>>>> Developers
        public int PlantaId { get; set; }
      
    }
}
