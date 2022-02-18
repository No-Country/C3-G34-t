using System.ComponentModel.DataAnnotations;

namespace MaxionMontichV2.Models
{
    public class FormTablerosElectricos
    {
        [Key]
        public int Id { get; set; }
        public int TableroYSector { get; set; }
        public int CarteleriaSeñalizada { get; set; }
        public int CarteleriaBuenEstado { get; set; }
        public int CarteleriaEPP { get; set; }
        public int MPCProcEscritos { get; set; }
        public int MPCCandadosTarjetas { get; set; }
        public int MPCTableroProtegido { get; set; }
        public int EPPCalzadoDielectrico { get; set; }
        public int EPPGuantesDielectrico { get; set; }
        public int EPPLentes { get; set; }
        public int TableroLibre { get; set; }
        public int Cerradura { get; set; }
        public int OrdenLimpieza { get; set; }
        public int Matafuegos { get; set; }
        public string Observaciones { get; set; }
        public string RespSolucion { get; set; }

        public Opciones opciones { get; set; }

}
}
