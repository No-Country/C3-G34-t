using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Models
{
    public class FormHyM : FormBase
    {
        [Key]
        public int Id { get; set; }
        public string IdHyM { get; set; }
        public string Puesto { get; set; }
        public string EPP { get; set; }
        public string LimpiezaYorganizacion { get; set; }
        public string Protecciones { get; set; }
        public string DoblesPulsadores { get; set; }
        public string ParadaDeEmergencia { get; set; }
        public string BarreraOpticaEnclavamientoElectrico { get; set; }
        public string HerramientasManuales { get; set; }
        public string PerdidasAireAguaAceite { get; set; }
        public string Iluminacion { get; set; }
        public string CondicionesInseguras { get; set; }
        public string CarrosEmbalajes { get; set; }
        public string PuertasTablerosElectricos { get; set; }
        public string GuinchesBalanceadores { get; set; }
        public string Entrenamiento { get; set; }
    }
}
