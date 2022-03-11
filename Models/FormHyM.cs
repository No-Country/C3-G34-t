using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Models
{
    public class FormHyM : FormBase
    {
<<<<<<< HEAD
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
=======
        [Required]
        [Display(Name = "ID Herramienta / Maquinaria")]
        public int IdHyM { get; set; }

        [Required]
        public string Puesto { get; set; }

        [Required]
        [Display(Name = "Elementos de Protección Personal")]
        public string EPP { get; set; }

        [Required]
        [Display(Name = "Limpieza y Organización")]
        public string LimpiezaYorganizacion { get; set; }

        [Required]
        public string Protecciones { get; set; }

        [Required]
        [Display(Name = "Dobles Pulsadores")]
        public string DoblesPulsadores { get; set; }

        [Required]
        [Display(Name = "Parada de Emergencia")]
        public string ParadaDeEmergencia { get; set; }

        [Required]
        [Display(Name = "Barrera Óptica Enclavamiento Eléctrico")]
        public string BarreraOpticaEnclavamientoElectrico { get; set; }

        [Required]
        [Display(Name = "Herramientas Manuales")]
        public string HerramientasManuales { get; set; }

        [Required]
        [Display(Name = "Pérdidas Aire / Agua / Aceite")]
        public string PerdidasAireAguaAceite { get; set; }

        [Required]
        [Display(Name = "Iluminación")]
        public string Iluminacion { get; set; }

        [Required]
        [Display(Name = "Condiciones Inseguras")]
        public string CondicionesInseguras { get; set; }

        [Required]
        [Display(Name = "Carros Embalajes")]
        public string CarrosEmbalajes { get; set; }

        [Required]
        [Display(Name = "Puertas Tableros Eléctricos")]
        public string PuertasTablerosElectricos { get; set; }

        [Required]
        [Display(Name = "Guinches Balanceadores")]
        public string GuinchesBalanceadores { get; set; }

        [Required]
>>>>>>> Developers
        public string Entrenamiento { get; set; }
    }
}
