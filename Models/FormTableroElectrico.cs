using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AuditApp.Models
{
    public class FormTableroElectrico : FormBase
    {
        [Key]
        public int Id { get; set; }
        public string TableroYSector { get; set; }
        public string CarteleriaSeñalizada { get; set; }
        public string CarteleriaBuenEstado { get; set; }
        public string CarteleriaEPP { get; set; }
        public string MPCProcEscritos { get; set; }
        public string MPCCandadosTarjetas { get; set; }
        public string MPCTableroProtegido { get; set; }
        public string EPPCalzadoDielectrico { get; set; }
        public string EPPGuantesDielectrico { get; set; }
        public string EPPLentes { get; set; }
        public string TableroLibre { get; set; }
        public string Cerradura { get; set; }
        public string OrdenLimpieza { get; set; }
        public string Matafuegos { get; set; }
        
    }
}
