using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Models
{
    public class FormAutoElevadores : FormBase
    {
        [Required]
        public string ElevadorID { get; set; }
        [Required]
        public string EtiquetaCargaMaxima { get; set; }
        [Required]
        public string EtiquetasCurvas { get; set; }
        [Required]
        public string Etiquetastringerna { get; set; }
        [Required]
        public string IRAM8412 { get; set; }
        [Required]
        public string EstructuraContraCaidas { get; set; }
        [Required]
        public string ProteccionLLuvia { get; set; }
        [Required]
        public string SeguridadMandos { get; set; }
        [Required]
        public string SillaConductor { get; set; }
        [Required]
        public string CinturonSeguridad { get; set; }
        [Required]
        public string LucesGiroFreno { get; set; }
        [Required]
        public string LucesTrabajo { get; set; }
        [Required]
        public string Bocina { get; set; }
        [Required]
        public string AvisoRetroceso { get; set; }
        [Required]
        public string EspejosRetrovisores { get; set; }
        [Required]
        public string Arrestallamas { get; set; }
        [Required]
        public string DispositivoAislante{ get; set; }
        [Required]
        public string FrenoEstacionario { get; set; }
        [Required]
        public string CuñasRuedas { get; set; }
        [Required]
        public string Extintor { get; set; }
        [Required]
        public string MediosAsensoDesenso { get; set; }
        [Required]
        public string AntideslizantesManoPisos { get; set; }
        [Required]
        public string ManualOperario { get; set; }
        [Required]
        public string CarteleraVelocidades { get; set; }
        [Required]
        public string CarteleraViasCirculacion { get; set; }
        [Required]
        public string CarteleraProhibicionCarga { get; set; }
        [Required]
        public string SeñalizacionAltura { get; set; }
        [Required]
        public string CarteleraCinturon { get; set; }
        [Required]
        public string CarteleraAtrapamiento { get; set; }
        [Required]
        public string CarteleraAplicarFreno { get; set; }
        [Required]
        public string CarteleraInfladoNeumaticos { get; set; }
        [Required]
        public string CarteleraVelocidadCirculacionAut { get; set; }
        [Required]
        public string CarteleraProhibicionPersonas { get; set; }
        [Required]
        public string CarteleraProhibicionCircPersonas { get; set; }
        [Required]
        public string CarteleraRiesgosBateriasYGas { get; set; }

        // pregunta 12 mockup
        [Required]
        public string OperacionPersonalAut { get; set; }
        [Required]
        public string ListadoControlRuedas { get; set; }
        [Required]
        public string ListadoFijacionBrazos { get; set; }
        [Required]
        public string ListadoFugasFluidos { get; set; }
        [Required]
        public string ListadoNivelAceite { get; set; }
        [Required]
        public string CheckMandosServicio { get; set; }
        [Required]
        public string CheckBocina { get; set; }
        [Required]
        public string CheckLuces { get; set; }
        [Required]
        public string CheckAvisoRetroceso { get; set; }
        [Required]
        public string CheckFrenoPieMano { get; set; }
        [Required]
        public string CheckEspejos { get; set; }
        [Required]
        public string CheckExtintor { get; set; }
        [Required]
        public string CheckCinturonSeguridad { get; set; }
        [Required]
        public string CheckSistemaTransmision { get; set; }
        [Required]
        public string CheckEstadoAsiento { get; set; }
        [Required]
        public string InformeReparaciones { get; set; }
        [Required]
        public string SeñalizacionFueraServicio { get; set; }
        [Required]
        public string RevisionGeneralTriMestral { get; set; }
        [Required]
        public string ProgramaMantenimiento { get; set; }
        [Required]
        public string ElementosProteccionGLP { get; set; }


    }
}
