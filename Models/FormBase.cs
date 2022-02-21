using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Models
{
    public class FormBase
    {
        public int AuditorId { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public string ResponsableDesvio{ get; set; }
        public int PlantaId { get; set; }
      
    }
}
