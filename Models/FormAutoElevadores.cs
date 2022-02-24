using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApp.Models
{
    public class FormAutoElevadores : FormBase
    {
        public string ElevadorID { get; set; }
        public string EtiquetaCargaMaxima { get; set; }
        public string EtiquetasCurvas { get; set; }
        public string Etiquetastringerna { get; set; }
        public string IRAM8412 { get; set; }
        public string EstructuraContraCaidas { get; set; }
        public string ProteccionLLuvia { get; set; }
        public string SeguridadMandos { get; set; }
        public string SillaConductor { get; set; }
        public string CinturonSeguridad { get; set; }
        public string LucesGiroFreno { get; set; }
        public string LucesTrabajo { get; set; }
        public string Bocina { get; set; }
        public string AvisoRetroceso { get; set; }
        public string EspejosRetrovisores { get; set; }
        public string Arrestallamas { get; set; }
        public string FrenoEstacionario { get; set; }
        public string CuñasRuedas { get; set; }
        public string Extintor { get; set; }
        public string MediosAsensoDesenso { get; set; }
        public string AntideslizantesManoPisos { get; set; }
        public string ManualOperario { get; set; }
        public string CarteleraVelocidades { get; set; }
        public string CarteleraViasCirculacion { get; set; }
        public string CarteleraProhibicionCarga { get; set; }
        public string SeñalizacionAltura { get; set; }
        public string CarteleraCinturon { get; set; }
        public string CarteleraAtrapamiento { get; set; }
        public string CarteleraInfladoNeumaticos { get; set; }
        public string CarteleraVelocidadCirculacionAut { get; set; }
        public string CarteleraProhibicionPersonas { get; set; }
        public string CarteleraVelocidadCirculacionPer { get; set; }
        public string CarteleraRiesgosBateriasYGas { get; set; }

        // pregunta 12 mockup
        public string OperacionPersonalAut { get; set; }

        public string ListadoControlRuedas { get; set; }
        public string ListadoFijacionBrazos { get; set; }
        public string ListadoFugasFluidos { get; set; }
        public string ListadoNivelAceite { get; set; }
        public string CheckMandosServicio { get; set; }
        public string CheckBocina { get; set; }
        public string CheckLuces { get; set; }
        public string CheckAvisoRetroceso { get; set; }
        public string CheckFrenoPieMano { get; set; }
        public string CheckEspejos { get; set; }
        public string CheckExtintor { get; set; }
        public string CheckCinturonSeguridad { get; set; }
        public string CheckSistemaTransmision { get; set; }
        public string CheckEstadoAsiento { get; set; }
        public string InformeReparaciones { get; set; }
        public string SeñalizacionFueraServicio { get; set; }
        public string RevisionGeneralTriMestral { get; set; }
        public string ProgramaMantenimiento { get; set; }
        public string ElementosProteccionGLP { get; set; }


    }
}
