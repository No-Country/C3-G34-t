using System.Collections.Generic;

namespace MaxionMontichV2.Models
{
    public class Opciones
    {
        public int Id { get; set; }
        public string Cumple { get; set; }

        public string NoCumple { get; set; }

        public string NoAplica { get; set; }

        public List<FormTablerosElectricos> FormTablerosElec { get; set; }
        public List<FormHyM> FormHyM { get; set; }
        public List<FormElevadores> FormElevadores { get; set; }
    }
}
