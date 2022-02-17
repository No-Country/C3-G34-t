using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaxionMontichV2.Models
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        public List<Usuario> ListUusarios { get; set; }
    }
}
