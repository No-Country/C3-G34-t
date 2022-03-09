using System.ComponentModel.DataAnnotations;

namespace AuditApp.Models
{
    public class AuditoriasView
    {
        [Display(Name = "Razón Social / Empresa")]
        public string PlantaName { get; set; }
        [Display(Name = "Tipo de Formulario")]
        public string TipoFormulario { get; set; }
        [Display(Name = "Fecha de Auditoría")]
        public string Fecha { get; set; }
        public string controlador { get; set; }
        [Display(Name = "ID de Formulario")]
        public int IdFormulario { get; set; }
    }
}
