using System.ComponentModel.DataAnnotations;

namespace MaxionMontichV2.Models
{
    public class FormElevadores
    {
        [Key]
        public int Id { get; set; }

        public Opciones opciones { get; set; }

    }
}
