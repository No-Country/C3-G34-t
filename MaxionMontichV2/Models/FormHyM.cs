using System.ComponentModel.DataAnnotations;

namespace MaxionMontichV2.Models
{
    public class FormHyM
    {
        [Key]
        public int IdForHyM { get; set; }
        public string EquipoMaquina { get; set; }
        public string Puesto { get; set; }
        public string EPP { get; set; }
        public string limpiezaYorganizacion { get; set; }
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
        public string Observaciones { get; set; }
        public string RespSolucion { get; set; }

        public Opciones opciones { get; set; }
    }
}
