using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Models
{
    public class Planta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Razón Social / Empresa")]
        public string Nombre { get; set; }
        //public string Codigo { get; set; }
        //public List<TablerosElectricos> TablerosElec { get; set; }
        //public List<HyM> HyM { get; set; }
        //public List<Elevadores> Elevadores { get; set; }
    }
}
