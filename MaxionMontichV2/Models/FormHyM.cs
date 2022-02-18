using System.ComponentModel.DataAnnotations;

namespace MaxionMontichV2.Models
{
    public class FormHyM
    {
        [Key]
        public int Id { get; set; }
        public int IdHyM { get; set; }
        public int Puesto { get; set; }
        public int EPP { get; set; }
        public int limpiezaYorganizacion { get; set; }
        public int Protecciones { get; set; }
        public int DoblesPulsadores { get; set; }
        public int ParadaDeEmergencia { get; set; }
        public int BarreraOpticaEnclavamientoElectrico { get; set; }
        public int HerramientasManuales { get; set; }
        public int PerdidasAireAguaAceite { get; set; }
        public int Iluminacion { get; set; }
        public int CondicionesInseguras { get; set; }
        public int CarrosEmbalajes { get; set; }
        public int PuertasTablerosElectricos { get; set; }
        public int GuinchesBalanceadores { get; set; }
        public int Entrenamiento { get; set; }
        public string Observaciones { get; set; }
        public string RespSolucion { get; set; }

        public Opciones opciones { get; set; }
         
    }
}
