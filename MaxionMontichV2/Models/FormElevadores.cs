using System.ComponentModel.DataAnnotations;

namespace MaxionMontichV2.Models
{
    public class FormElevadores
    {
        [Key]
        public int Id { get; set; }
        //
        public int PlantaId { get; set; }
        public int ElevadorID { get; set; }
        public int EtiquetaCargaMaxima { get; set; }
        public int EtiquetasCurvas { get; set; }
        public int EtiquetaInterna { get; set; }
        public int IRAM8412 { get; set; }
        public int EstructuraContraCaidas { get; set; }
        public int ProteccionLLuvia { get; set; }
        public int SeguridadMandos { get; set; }
        public int SillaConductor { get; set; }
        public int CinturonSeguridad { get; set; }
        public int LucesGiroFreno { get; set; }
        public int LucesTrabajo { get; set; }
        public int Bocina { get; set; }
        public int AvisoRetroceso { get; set; }
        public int EspejosRetrovisores { get; set; }
        public int Arrestallamas { get; set; }
        public int FrenoEstacionario { get; set; }
        public int CuñasRuedas { get; set; }
        public int Extintor { get; set; }
        public int MediosAsensoDesenso { get; set; }
        public int AntideslizantesManoPisos { get; set; }
        public int ManualOperario { get; set; }
        public int CarteleraVelocidades { get; set; }
        public int CarteleraViasCirculacion { get; set; }
        public int CarteleraProhibicionCarga { get; set; }
        public int SeñalizacionAltura { get; set; }
        public int CarteleraCinturon { get; set; }
        public int CarteleraAtrapamiento { get; set; }
        public int CarteleraInfladoNeumaticos { get; set; }
        public int CarteleraVelocidadCirculacionAut { get; set; }
        public int CarteleraProhivicionPersonas { get; set; }
        public int CarteleraVelocidadCirculacionPer { get; set; }
        public int CarteleraRiesgosBateriasYGas { get; set; }

        // pregunta 12 mockup
        public int OperacionPersonalAut { get; set; }
        
        public int ListadoControlRuedas { get; set; }
        public int ListadoFijacionBrazos { get; set; }
        public int ListadoFugasFluidos { get; set; }
        public int ListadoNivelAceite { get; set; }
        public int CheckMandosServicio { get; set; }
        public int CheckBocina { get; set; }
        public int CheckLuces { get; set; }
        public int CheckAvisoRetroceso { get; set; }
        public int CheckFrenoPieMano { get; set; }
        public int CheckEspejos { get; set; }
        public int CheckExtintor { get; set; }
        public int CheckCinturonSeguridad { get; set; }
        public int CheckSistemaTransmision { get; set; }
        public int CheckEstadoAsiento { get; set; }
        public int InformeReparaciones { get; set; }
        public int SeñalizacionFueraServicio { get; set; }
        public int RevisionGeneralTriMestral { get; set; }
        public int ProgramaMantenimiento { get; set; }
        public int ElementosProteccion { get; set; }
        public string Observaciones  { get; set; }
        public string Auditor  { get; set; }
        public Opciones opciones { get; set; }

    }
}
