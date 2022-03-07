using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AuditApp.Models
{
    public class FormTableroElectrico : FormBase
    {
        [Required]
        [Display(Name = "Nº de Tablero y Sector")]
        public string TableroYSector { get; set; }
        [Required]
        [Display(Name = "4. Cartelería: se encuentra señalizado correctamente")]
        public string CarteleriaSeñalizada { get; set; }
        [Required]
        [Display(Name = "5. Cartelería: se encuentra en buen estado la señalización")]
        public string CarteleriaBuenEstado { get; set; }
        [Required]
        [Display(Name = "6. Cartelería: indica la utilización de EPP")]
        public string CarteleriaEPP { get; set; }
        [Required]
        [Display(Name = "7. Medidas de Protección Colectiva: cuentan con procedimientos de trabajo escritos")]
        public string MPCProcEscritos { get; set; }
        [Required]
        [Display(Name = "8. Medidas de Protección Colectiva: utilizan candados, tarjetas de señalización")]
        public string MPCCandadosTarjetas { get; set; }
        [Required]
        [Display(Name = "9. Medidas de Protección Colectiva: el tablero está protegido para evitar contactos directos")]
        public string MPCTableroProtegido { get; set; }
        [Required]
        [Display(Name = "10. EPP: utilizan calzado dieléctrico")]
        public string EPPCalzadoDielectrico { get; set; }
        [Required]
        [Display(Name = "11. EPP: utilizan guantes dieléctricos")]
        public string EPPGuantesDielectrico { get; set; }
        [Required]
        [Display(Name = "12. EPP: utilizan lentes de seguridad")]
        public string EPPLentes { get; set; }
        [Required]
        [Display(Name = "13. Otros: los tableros tienen libre acceso")]
        public string TableroLibre { get; set; }
        [Required]
        [Display(Name = "14. Otros: poseen cerraduras las puertas")]
        public string Cerradura { get; set; }
        [Required]
        [Display(Name = "15. Otros: mantenimiento del orden y la limpieza")]
        public string OrdenLimpieza { get; set; }
        [Required]
        [Display(Name = "16. Otros: posee matafuegos, tipo adecuado")]
        public string Matafuegos { get; set; }
        
    }
}
